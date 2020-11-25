using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchetAvto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            cbType.Items.AddRange(new string[] { "Admin", "Manager", "Driver" });
            cbType.SelectedIndex = 0;
        }
        #region Validating
        private bool CheckUser(string email, string password, string type)
        {
            return DataLogic.CheckUser(email, email, password, type); ;
        }

        private bool CheckEmail(string email)
        {
            if (email.Contains("@") && email.Contains(".")) return true;
            else MessageBox.Show("Неверный формат Email!\nПроверьте правильность введенных данных!"); return false;
        }

        private bool CheckType(string type)
        {
            if (type == "Admin" || type == "Manager" || type == "Driver") return true;
            else MessageBox.Show("Данный тип пользователя не сущуствует!\nВыберите тип из предложенных."); return false;
        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            string email = tbEmail.Text;
            string password = tbPassword.Text;
            string type = cbType.Text;
            if (CheckType(type) && CheckUser(email, password, type))
            {
                main.TYPE = type;
                main.Show(); 
                Hide();
            }
            else MessageBox.Show("Ошибка входа!");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
