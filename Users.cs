using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchetAvto
{
    public partial class Users : Form
    {
        private List<DataObjects.Users> users = new List<DataObjects.Users>();
        public Users()
        {
            InitializeComponent();
            users = DataLogic.GetUsers("");
        }

        private void Users_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Email";
            dataGridView1.Columns[2].Name = "Пароль";
            dataGridView1.Columns[3].Name = "Имя пользователя";
            dataGridView1.Columns[4].Name = "Тип пользователя";
            
            string[] row;
            foreach (var u in users)
            {
                row = new string[] { u.Id, u.Email, u.Pass, u.Username, u.UserType};
                dataGridView1.Rows.Add(row);
            }
        }

        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main m = new Main();
            m.Show();
        }
    }
}
