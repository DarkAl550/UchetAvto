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
    public partial class Lists : Form
    {
        List<DataObjects.PutLists> putLists = new List<DataObjects.PutLists>();
        DataLogic dl = new DataLogic();
        public Lists()
        {
            InitializeComponent();
            putLists = dl.GetPutLists("");
            
        }

        private void Lists_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "№ Путевого листа";
            dataGridView1.Columns[1].Name = "№ Транспорта";
            dataGridView1.Columns[2].Name = "№ Водителя";
            dataGridView1.Columns[3].Name = "Дата Выезда";
            dataGridView1.Columns[4].Name = "Дата возврата";
            dataGridView1.Columns[5].Name = "Кол-во топлива при отправке";
            dataGridView1.Columns[6].Name = "Кол-во топлива по прибытию";
            dataGridView1.Columns[7].Name = "№ Маршрута";
            dataGridView1.Columns[8].Name = "Масса груза";
            string[] row;
            foreach (var l in putLists){
                row = new string[] { l.Id, l.CarId, l.DriverId, l.Date_Start, l.Date_End, l.Start_Oils, l.End_Oils, l.MarshrutId, l.Mass};
                dataGridView1.Rows.Add(row);

            }
            

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            Close();
        }
    }
}
