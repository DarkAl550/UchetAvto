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
    public partial class Transport : Form
    {
        private List<DataObjects.Car> cars = new List<DataObjects.Car>();
 
        public Transport()
        {
            InitializeComponent();
            cars = DataLogic.GetCars("");
        }

        private void Transport_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 14;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Название";
            dataGridView1.Columns[2].Name = "Марка";
            dataGridView1.Columns[3].Name = "Тип";
            dataGridView1.Columns[4].Name = "Организация";
            dataGridView1.Columns[5].Name = "Колонна";
            dataGridView1.Columns[6].Name = "Год выпуска";
            dataGridView1.Columns[7].Name = "Гос номер";
            dataGridView1.Columns[8].Name = "Номер двигателя";
            dataGridView1.Columns[9].Name = "Номер кузова";
            dataGridView1.Columns[10].Name = "Состояние";
            dataGridView1.Columns[11].Name = "Максимальная скорость";
            dataGridView1.Columns[12].Name = "Марка топлива";
            dataGridView1.Columns[13].Name = "Расход топлива";

            string[] row;
            foreach (var c in cars)
            {
                List<DataObjects.Car_Type> car_Types = DataLogic.getCarTypes($"WHERE Id = {c.CarTypeId}");
                List<DataObjects.Oil_Marks> oil_marks = DataLogic.GetOilsMarks($"WHERE Id = {c.OilMarksId}");
                string car_typesID = car_Types[0].CarType;
                string colonna = (c.Colonna == "true") ? "Да" : "Нет";
                row = new string[] { c.Id,
                    c.Name_Car,
                    c.Marks,
                    car_typesID,
                    c.Org,
                    colonna,
                    c.Date_realese,
                    c.Car_Number,
                    c.Motor_Number,
                    c.Kuzov_Number,
                    c.Tech_Status,
                    c.Max_Speed,
                    oil_marks[0].Oil_Mark,
                    c.Oils_Lost

                };
                dataGridView1.Rows.Add(row);

            }
        }

        private void Transport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main m = new Main();
            m.Show();
        }
    }
}
