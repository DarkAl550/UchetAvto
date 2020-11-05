using System;
using System.Data.SqlClient;

namespace UchetAvto
{
    public class DataLogic : DataManager
    {
        public bool CheckUser(string username, string email, string password, string type)
        {
            string parametrs = $"WHERE Username = '{username}' OR Email = '{email}' AND Pass = '{password}' AND UserType = '{type}";
            SqlDataReader getUser = SelectValues("Users", parametrs);

            if (getUser.Read())
            {
                getUser.Close();
                ConnClosed();
                return true;
            }
            else
            {
                getUser.Close();
                ConnClosed();
                return false;
            }

        }
    }
}
