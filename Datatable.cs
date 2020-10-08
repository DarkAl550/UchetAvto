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
    public partial class Datatable : Form
    {
        public Datatable()
        {
            InitializeComponent();
        }

        private void Datatable_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetAvtoDataSet.Маршруты". При необходимости она может быть перемещена или удалена.
            this.marshrutsTableAdapter.Fill(this.uchetAvtoDataSet.Маршруты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetAvtoDataSet.Водители". При необходимости она может быть перемещена или удалена.
            this.driversTableAdapter.Fill(this.uchetAvtoDataSet.Водители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetAvtoDataSet.Транспорт". При необходимости она может быть перемещена или удалена.
            this.transportTableAdapter.Fill(this.uchetAvtoDataSet.Транспорт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetAvtoDataSet.Тип_Транспорта". При необходимости она может быть перемещена или удалена.
            this.transportTypeTableAdapter.Fill(this.uchetAvtoDataSet.Тип_Транспорта);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetAvtoDataSet.Путевые_листы". При необходимости она может быть перемещена или удалена.
            this.listsTableAdapter.Fill(this.uchetAvtoDataSet.Путевые_листы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetAvtoDataSet.Марка_топлива". При необходимости она может быть перемещена или удалена.
            this.oilsMarksTableAdapter.Fill(this.uchetAvtoDataSet.Марка_топлива);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetAvtoDataSet.Заправка". При необходимости она может быть перемещена или удалена.
            this.oilsTableAdapter.Fill(this.uchetAvtoDataSet.Заправка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetAvtoDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.uchetAvtoDataSet.Users);

        }
        public bool DataGridViewRow(string email, string password, string type)
        {
            List<string> stringRows = new List<string>();
            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                stringRows.Add(row.ToString());
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dgvUsers.Update();
            dgvUsers.Refresh();
        }
    }
}
