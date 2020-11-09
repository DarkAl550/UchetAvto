using System;
using System.Data.SqlClient;

namespace UchetAvto
{
    public class DatabaseManager
    {
        /* !!!EDIT SERVER PATH !!! */
        //Data Source=HOME-PC\SQLEXPRESS;Initial Catalog=UchetAvto;Integrated Security=True
        public static string connPath = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=UchetAvto;Integrated Security=True";//conection string

        SqlConnection conn = new SqlConnection(connPath);

        public void ConnOpen()
        {
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
        }

        public void ConnClosed()
        {
            if (conn.State == System.Data.ConnectionState.Open) conn.Close();
        }

        public SqlConnection SqlConnection()
        { 
            return conn;
        }
    }
}
