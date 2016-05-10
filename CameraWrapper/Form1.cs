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
        DatabaseHelper.DatabaseHelper DBHelper = new DatabaseHelper.DatabaseHelper("18.62.9.117","18.62.9.117","root","w0lfg4ng", "BECIVDatabase");


        short exp_check1 = 1;
        dynamic exp_check;

        public Form1()
        {
            InitializeComponent();
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
 //               MessageBox.Show(Convert.ToString(acquirebut_check));
                experiment_check();
                if (exp_check == 0)
                {
                    newExp.Start(WinVFile);
                }
                WinVFile = newExp.GetDocument();
            Check_Camera:
//                MessageBox.Show(Convert.ToString(exp_check));
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
                    goto Check_Camera;
               }
               else if (exp_check == 0)
               {

//                   MessageBox.Show("Acq=T, ec=0");
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
 //           DatabaseHelper.imageStruct newstr = new DatabaseHelper.imageStruct();
            short depth1, width1, height1;
            dynamic depth = newExp.GetParam(EXP_CMD.EXP_SEQUENTS, out depth1);                  // Returns number of sequential frames
            dynamic width = newExp.GetParam(EXP_CMD.EXP_XDIM, out width1);                   //Returns width or x dimension size
            dynamic height = newExp.GetParam(EXP_CMD.EXP_YDIM, out height1);
//            newstr.depth = Convert.ToInt16(depth);
//            newstr.width = Convert.ToInt16(width);
//            newstr.height = Convert.ToInt16(height);
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
//                int a = 1;
            }
            if (data != null)
            {
                DBHelper.writeImageDataToDB(data, depth, width, height, camID, runID, seqID);
                //DBHelper.writeImageDataToCache(data, depth, width, height, camID, runID, seqID);
                int a = 1;
            }
            WinVFile.Close();
            newExp.Stop();
            //DatabaseHelper.imageStruct result = new DatabaseHelper.imageStruct();
            //result =newFile.readImageFromCache();
            //MessageBox.Show(Convert.ToString(result.cameraID));
            //MessageBox.Show(Convert.ToString(result.depth));
            //MessageBox.Show(Convert.ToString(result.data));

        }

        async Task PutTaskDelay()
        {
            await Task.Delay(500);
        }

        private void newCameraID_Click(object sender, EventArgs e)
        {
            //           Application.Run(new Form2());
            Form cameraIDform = new Form2();
            cameraIDform.Show();
        }
    }
}
