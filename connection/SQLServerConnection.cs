using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POS_Team_Elite.connection
{
    class SQLServerConnection
    {

        public string ConnString() {

            string CONN = "Data Source=DEVELOPER\\SQLEXPRESS;Initial Catalog=EliteDB;Integrated Security=True";
            return CONN;

        } 
    }
}
