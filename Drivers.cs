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
    public partial class Drivers : Form
    {

        List<DataObjects.Drivers> drivers = new List<DataObjects.Drivers>();
       
        public Drivers()
        {
            InitializeComponent();
        }

        private void Drivers_Load(object sender, EventArgs e)
        {
            drivers = DataLogic.GetDrivers("");

            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Фамилия";
            dataGridView1.Columns[2].Name = "Имя";
            dataGridView1.Columns[3].Name = "Отчество";
            dataGridView1.Columns[4].Name = "Дата рождения";
            dataGridView1.Columns[5].Name = "Время работы";
            dataGridView1.Columns[6].Name = "Зарплата";
            dataGridView1.Columns[7].Name = "Категория";

            string[] row;
            foreach (var d in drivers)
            {
                row = new string[] { d.Id, d.LastName, d.FirstName, d.AfterName, d.DateBorn, d.WorkTime, d.Currency, d.Category };
                dataGridView1.Rows.Add(row);

            }
        }

        private void Drivers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main m = new Main();
            m.Show();
        }
    }
}
