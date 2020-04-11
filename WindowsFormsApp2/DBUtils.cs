﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp2
{
    public static class DBUtils
    {
        public static string datasource;
        public static string database;
        public static string username;
        public static string password;

        public static string Datasource1
        {
            get { return datasource; }
            set { datasource = Convert.ToString(Form6.ReadSetting("datasource")); }
        }

        public static string Database1
        {
            get { return database; }
            set { database = Convert.ToString(Form6.ReadSetting("database")); }
        }

        public static string Username1
        {
            get { return username; }
            set { username = Convert.ToString(Form6.ReadSetting("username")); }
        }


        public static string Password1
        {
            get { return password; }
            set { password = Convert.ToString(Form6.ReadSetting("password")); }
        }


        public static SqlConnection GetDBConnection()
        {

            string datasource12 = Convert.ToString(Datasource1);
            string database12 = Convert.ToString(Database1);
            string username12 = Convert.ToString(Username1);
            string password12 = Convert.ToString(Password1);
            return DBSQLServerUtils.GetDBConnection(datasource12, database12, username12, password12);
        }
    }
}