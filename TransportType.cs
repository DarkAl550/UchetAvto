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
    public partial class TransportType : Form
    {
        List<DataObjects.Car_Type> car_Types = new List<DataObjects.Car_Type>();
        DataLogic dl = new DataLogic();
        public TransportType()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TransportType_Load(object sender, EventArgs e)
        {
            car_Types = dl.getCarTypes("");
            
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Тип";
            
            string[] row;
            foreach (var ct in car_Types)
            {
                row = new string[] { ct.Id, ct.CarType };
                dataGridView1.Rows.Add(row);

            }
        }

        private void TransportType_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main m = new Main();
            m.Show();
            
        }
    }
}
