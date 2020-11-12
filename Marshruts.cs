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
    public partial class Marshruts : Form
    {
        List<DataObjects.Marshruts> marshruts = new List<DataObjects.Marshruts>();
        DataLogic dl = new DataLogic();
        DataManager dm = new DataManager();
        public Marshruts()
        {
            InitializeComponent();
            marshruts = dl.GetMarshruts("");
        }

        private void Marshruts_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main m = new Main();
            m.Show();
        }

        private void Marshruts_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "№ Маршрута";
            dataGridView1.Columns[1].Name = "Откуда";
            dataGridView1.Columns[2].Name = "Куда";
            dataGridView1.Columns[3].Name = "Дата Выезда";
            dataGridView1.Columns[4].Name = "Дата приезда";
            dataGridView1.Columns[5].Name = "Расстояние";
            dataGridView1.Columns[6].Name = "Топлива потрачено";
            dataGridView1.Columns[7].Name = "Время на сон";
            
            string[] row;
            foreach (var m in marshruts)
            {
               
                row = new string[] { m.Id,
                    m.From,
                    m.To,
                    m.Date_Start,
                    m.Date_End,
                    m.Length,
                    m.Oils_lost,
                    m.Time_to_sleep
                };
                dataGridView1.Rows.Add(row);

            }
        }
    }
}
