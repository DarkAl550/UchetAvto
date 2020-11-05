using System;
using System.Data.SqlClient;

namespace UchetAvto
{
    public class DatabaseManager
    {
        /* !!!EDIT SERVER PATH !!! */
        public static string connPath = "Data Source=DESKTOP-SJBK3TL\\TRANSBD;Initial Catalog=UchetAvto;Persist Security Info=True;User ID=DBC;Password=12345";//conection string

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
