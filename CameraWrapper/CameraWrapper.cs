//Look at Form 1 for updated file!!! This is not being used.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Enyim.Caching;
using Enyim.Caching.Configuration;
using Enyim.Caching.Memcached;
using DatabaseHelper;
using WINX32Lib;


namespace CameraWrapperClass
{
    public class CameraWrapperClass
    {
        public void Main()
        {
            short i = 1;
            //            float[,] p = new float();
            ExpSetup  newExp = new ExpSetup();
            IDocFile abc = newExp.GetDocument();
//            DocFile abc = new DocFile();
            newExp.Start(ref abc);
            short check, frames;
            short width, height;
            newExp.GetParam(EXP_CMD.EXP_RUNNING_EXPERIMENT, out check);            //Returns 1 if experiment is running, else 0
            object newObj = new object();
            abc.GetFrame(i, ref newObj);
            newExp.GetParam(EXP_CMD.EXP_SEQUENTS, out frames);                  // Returns number of sequential frames
            newExp.GetParam(EXP_CMD.EXP_XDIM, out width);                   //Returns width or x dimension size
            newExp.GetParam(EXP_CMD.EXP_YDIM, out height);                  //Returns height or y dimension size
            DateTime now = DateTime.Now;    //Gives current data time

            if (check == 1)
                {
                    //Experiment is running. Take image

                }
            else{ //Experiment is not running. Wait for next image
                }
            
            
            //            DatabaseHelper.DatabaseHelper x = new DatabaseHelper.DatabaseHelper();
            //            string x.name = "Hello";

            Console.WriteLine(i);
            Console.WriteLine(newObj.GetType());  
            
        }

    }
}
