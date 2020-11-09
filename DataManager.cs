using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchetAvto
{
    public class DataManager : DatabaseManager
    {

        public SqlDataReader SelectValues(string table, string parametrs)
        {
            ConnOpen();
            SqlCommand command = new SqlCommand($"SELECT * FROM [{table}] {parametrs}", SqlConnection());
            SqlDataReader read = command.ExecuteReader();
            return read;

        }

        public void InsertValuses(string table, string columns, string values, int id)
        {
            ConnOpen();
            string inserting = $"INSERT INTO [{table}]({columns}) VALUES(@id, {values})";
            SqlCommand command = new SqlCommand(inserting, SqlConnection());
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            int result = command.ExecuteNonQuery();
            if (result < 0)
                MessageBox.Show("Error inserting data into Database!");
            ConnClosed();
        }





    }
}
