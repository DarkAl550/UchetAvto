using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchetAvto
{
    class DataManager
    {
        public bool InsertedData(List<string> fields, string obj)
        {
            try
            {
                switch (obj)
                {
                    case "User":
                        InsertUser(fields);
                        return true;
                    case "NewList":
                        InsertNewList(fields);
                        return true;
                    default:
                        MessageBox.Show("Ошибка! Данной таблицы не существует {0}!", obj);
                        return false;
                        
                }
                
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }

        #region Inserting data
        private void InsertUser(List<string> fields)
        {
            int id;
            string email = fields[0];
            string password = fields[1];
            string username = fields[2];
            string type = fields[3];

            UchetAvtoDataSetTableAdapters.UsersTableAdapter userTableAdapter = new UchetAvtoDataSetTableAdapters.UsersTableAdapter();
            UchetAvtoDataSet users = new UchetAvtoDataSet();
            id = users.Users.Rows.Count + 1;
            userTableAdapter.Insert(id, email, password, username, type);
        }

        private void InsertNewList(List<string> fields)
        {

        }

        private List<string> InsertTransport(List<string> fields)
        {
            List<string> transportFields = new List<string>();
            return transportFields;
        }
        #endregion
    }
}
