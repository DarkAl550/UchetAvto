using System;
using System.Data.SqlClient;

namespace UchetAvto
{
    public class DatabaseManager
    {
        
        private static string connPath = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=UchetAvto;Integrated Security=True";//conection string
        private static SqlConnection conn = new SqlConnection(connPath);

        public static void ConnOpen()
        {
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
        }

        public static void ConnClosed()
        {
            if (conn.State == System.Data.ConnectionState.Open) conn.Close();
        }

        public static SqlConnection SqlConnection()
        { 
            return conn;
        }
    }
}
