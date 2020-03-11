using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"DESKTOP-9H4S4ED\SQLEXPRESS";
            string database = "ps_bankrussia";
            string username = "adminkbr";
            string password = "aA12345678";
            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}