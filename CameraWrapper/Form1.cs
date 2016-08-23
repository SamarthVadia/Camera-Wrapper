using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WINX32Lib;
using DatabaseHelper;

namespace CameraWrapper
{
    public partial class Form1 : Form
    {
        ExpSetup newExp = new ExpSetup();
        public static CameraWrapperSettings serverSettings = new CameraWrapperSettings();
        DatabaseHelper.DatabaseHelper DBHelper = new DatabaseHelper.DatabaseHelper(serverSettings.MemcachedServerIP, serverSettings.DatabaseServerIP, serverSettings.Username, serverSettings.Password, serverSettings.DBName);



        short exp_check1 = 1;
        dynamic exp_check;

        public Form1()
        {
            InitializeComponent();
            settingsGrid.SelectedObject = serverSettings;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool acquirebut_check = checkBox1.Checked;
            IDocFile WinVFile = newExp.GetDocument();
        Start_Camera:
            if (checkBox1.Checked== true)
            {
                DBHelper = new DatabaseHelper.DatabaseHelper(serverSettings.MemcachedServerIP, serverSettings.DatabaseServerIP, serverSettings.Username, serverSettings.Password, serverSettings.DBName);
                experiment_check();
                if (exp_check == 0)
                {
                    newExp.Start(WinVFile);
                }
                WinVFile = newExp.GetDocument();
            Check_Camera:
                experiment_check();
                if (checkBox1.Checked == false)
                {
                    WinVFile.Close();
                    newExp.Stop();
                    goto End;
                }
                if (exp_check == 1)
                {
                    await PutTaskDelay();
                    string type = serverSettings.HeartbeatTypeMethod.ToString();
                    if (type.Equals("On") == true)
                    {
                        DBHelper.setHeartbeat(serverSettings.CameraName);
                    }
                    goto Check_Camera;
               }
               else if (exp_check == 0)
               {

                   process_data(WinVFile);
                   goto Start_Camera;
               }
            }
            else
            {
                WinVFile.Close();
                newExp.Stop();
            }
        End:
            int random;
        }

        public void experiment_check()
        {
            exp_check = newExp.GetParam(EXP_CMD.EXP_RUNNING_EXPERIMENT, out exp_check1);
        }

        public void process_data(IDocFile WinVFile)
        {
            short depth1, width1, height1;
            dynamic depth = newExp.GetParam(EXP_CMD.EXP_SEQUENTS, out depth1);                  // Returns number of sequential frames
            dynamic width = newExp.GetParam(EXP_CMD.EXP_XDIM, out width1);                   //Returns width or x dimension size
            dynamic height = newExp.GetParam(EXP_CMD.EXP_YDIM, out height1);
            Int16[] data = new Int16[depth * width * height];
            string camID2 = cameraID.Text;
            int camID = Convert.ToInt32(camID2);
            int runID = DBHelper.getLastRunID();
            int seqID = DBHelper.getSequenceID();
            short frm = 1;
            short strip = 1;
            short pixel = 1;
            double pix= WinVFile.GetPixel(frm, strip, pixel);
            for (short i = 1; i <= depth; i++)
            {
                Int16[,] FrameVar0 = new Int16[width, height];
                object FrameVar = (object) FrameVar0; 
                if (FrameVar == null)
                {
                    break;
                }
                WinVFile.GetFrame(i, ref FrameVar);
                Int16[,] FrameVar1 = (Int16[,])FrameVar;
                Int16[] frame = new Int16[FrameVar1.GetLength(0) * FrameVar1.GetLength(1)];
                int framesize = frame.Length;
                Buffer.BlockCopy(FrameVar1, 0, frame, 0, framesize*2);
                Buffer.BlockCopy(frame, 0, data, (i-1)*framesize*2, framesize*2);
            }
            if (data != null)
            {
                string type = serverSettings.SaveTypeMethod.ToString();
                if (type.Equals("WriteToCache")==true)
                {
                    DBHelper.writeImageDataToCache(data, depth, width, height, camID, runID, seqID);
                    DBHelper.updateNewImage();
                }
                else
                {
                    DBHelper.writeImageDataToDB(data, depth, width, height, camID, runID, seqID);
                }
                
            }
            WinVFile.Close();
            newExp.Stop();

        }

        async Task PutTaskDelay()
        {
            await Task.Delay(500);
        }

        private void newCameraID_Click(object sender, EventArgs e)
        {
            Form cameraIDform = new Form2();
            cameraIDform.Show();
        }

        private void cameraID_TextChanged(object sender, EventArgs e)
        {
            string camID2 = cameraID.Text;
            if (camID2 == "")
            {
                goto End_Update;
            }
            int camID = Convert.ToInt32(camID2);
            DatabaseHelper.imageStruct newstr = new DatabaseHelper.imageStruct();
            newstr = DBHelper.getCameraData(camID);
            int h = newstr.height;
            int w = newstr.width;
            int d = newstr.depth;
            double ps = newstr.pixelSize;
            Height.Text = Convert.ToString(h);
            Width.Text = Convert.ToString(w);
            Depth.Text = Convert.ToString(d);
            PixelSize.Text = Convert.ToString(ps);
        End_Update:;
        }
    }
}
