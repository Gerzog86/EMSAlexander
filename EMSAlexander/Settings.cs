using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EMSAlexander
{
    static class Settings
    {

        public static string _serverAdress { get; set; } = "localhost";
        public static string _port { get; set; } = "3306";
        public static string _databaseName { get; set; } = "localbase";
        public static string _username { get; set; } = "anonymous";
        public static string _password { get; set; } = "";
        public static string _connectionstring { get; set; }


        public static bool Initialize()
        {
            FileStream fs = new FileStream("Settings.stg", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            _serverAdress = sr.ReadLine();
            _port = sr.ReadLine();
            _databaseName = sr.ReadLine();
            _username = sr.ReadLine();
            _password = sr.ReadLine();
            sr.Close();
            fs.Close();

            if (!(String.IsNullOrEmpty(_serverAdress)) && !(String.IsNullOrEmpty(_port)) && !(String.IsNullOrEmpty(_databaseName)) && !(String.IsNullOrEmpty(_username)))
            {
                _connectionstring = $"Data Source = {Settings._serverAdress}; Initial Catalog = {Settings._databaseName}; User ID = {Settings._username}; Password = {Settings._password}";
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
