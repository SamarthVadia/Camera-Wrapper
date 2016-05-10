using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseHelper;

namespace CameraWrapper
{
    public partial class Form2 : Form
    {
        DatabaseHelper.DatabaseHelper DBHelper = new DatabaseHelper.DatabaseHelper("127.0.0.1", "18.62.9.117", "root", "w0lfg4ng", "BECIVDatabase");
        private MySqlConnection conn = null;
        

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void height_TextChanged(object sender, EventArgs e)
        {
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            int h = Convert.ToInt32(height.Text);
            int w = Convert.ToInt32(width.Text);
            int d = Convert.ToInt32(depth.Text);
            float ps = Convert.ToSingle(pixelsize.Text);

            DBHelper.writeCameraDataToDB(ps, d, w, h);
            string myConnectionString = "server=18.62.9.117;uid=root;" + "pwd=w0lfg4ng;database=BECIVDatabase;";
            this.conn = new MySqlConnection(myConnectionString);
            conn.Open();
            MySqlCommand cmd1 = new MySqlCommand("SELECT cameraID FROM cameras ORDER BY cameraID DESC LIMIT 1", this.conn);
            cmd1.Prepare();
            MySqlDataReader reader = cmd1.ExecuteReader();
            int newcamID = 0;
            while (reader.Read())
            {
                newcamID = (int)reader[0];
            }
            reader.Close();
            MessageBox.Show(String.Format("Data added. Camera ID for data is: {0}", Convert.ToString(newcamID)));
        }
    }
}
