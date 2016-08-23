using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;

namespace CameraWrapper
{
    public class CameraWrapperSettings
    {

        private string databaseServerIP = "18.62.27.10";
        [Description("Sets the IP address of the computer running the MYSQL/MariaDB database"),
        Category("Database")]
        public string DatabaseServerIP
        {
            get { return databaseServerIP; }
            set { databaseServerIP = value; }
        }


        private string memcachedServerIP = "127.0.0.1";
        [Description("Sets the IP address of the computer running the memcached server"),
        Category("Memcached")]
        public string MemcachedServerIP
        {
            get { return memcachedServerIP; }
            set { memcachedServerIP = value; }
        }


        private string username = "root";
        [Description("Sets the username for  the MYSQL/MariaDB database"),
        Category("Database")]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }


        private string password ="w0lfg4ng";
        [Description("Sets the password for the MYSQL/MariaDB database"),
        Category("Database")]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        private string dbName="BECIVDatabase";
        [Description("Sets the name of the MYSQL/MariaDB database to connect to"),
       Category("Database")]
        public string DBName
        {
            get { return dbName; }
            set { dbName = value; }
        }

        public enum saveType {WriteToCache, WriteToDB};

        private saveType saveTypeMethod;
        [Description("Determines whether image is saved to Database or Cache"),
        Category("Save Type")]
        public saveType SaveTypeMethod
        {
            get { return saveTypeMethod; }
            set { saveTypeMethod = value; }
        }

        private string cameraName = "Camera1";
        [Description("Set the name of hearbeat monitor for Zeus"),
       Category("Heartbeat")]
        public string CameraName
        {
            get { return cameraName; }
            set { cameraName = value; }
        }

        public enum heartbeatType { On, Off };

        private heartbeatType heartbeatTypeMethod;
        [Description("Determines whether heartbeat is on or off from wrapper side"),
        Category("Heartbeat")]
        public heartbeatType HeartbeatTypeMethod
        {
            get { return heartbeatTypeMethod; }
            set { heartbeatTypeMethod = value; }
        }
    }
}
