using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Windows_Forms__.NET_Framework_
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Server=DESKTOP-E2L9BP7\SQLEXPRESS; Database=Задание2;Integrated Security=True");
        public void openConnection()
        { 
        if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection getConnection()
        { 
            return sqlConnection;
        }
    }
}
