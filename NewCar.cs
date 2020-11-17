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
    public partial class NewCar : Form
    {
        List<DataObjects.Car> cars = new List<DataObjects.Car>();
        List<DataObjects.Car_Type> car_types = new List<DataObjects.Car_Type>();
        List<DataObjects.Oil_Marks> oil_marks = new List<DataObjects.Oil_Marks>();
        
        DataLogic dl = new DataLogic();
        DataManager dm = new DataManager();
        public NewCar()
        {
            InitializeComponent();
        }

        private string[] GetCarType()
        {
            car_types = dl.getCarTypes("");
            string[] cars_types = new string[car_types.Count];
            for (int i = 0; i < car_types.Count; i++)
            {
                cars_types[i] = car_types[i].CarType;
            }

            return cars_types;
        }
        private string[] GetOilsMarks()
        {
            oil_marks = dl.GetOilsMarks("");
            string[] marks = new string[oil_marks.Count];
            for (int i = 0; i < oil_marks.Count; i++)
            {
                marks[i] = oil_marks[i].Oil_Mark;
            }

            return marks;
        }
        private void NewCar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main m = new Main();
            m.Show();
        }

        private void NewCar_Load(object sender, EventArgs e)
        {
            string[] listTypes = GetCarType();
            string[] listMarks = GetOilsMarks();
            comboBox1.Items.AddRange(listTypes);
            comboBox2.Items.AddRange(listMarks);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cars = dl.GetCars("");
            string car_typeId = dl.getCarTypes($"WHERE [Car Type] LIKE '{comboBox1.Text}'")[0].Id;
            string oil_markrId = dl.GetOilsMarks($"WHERE [Oil Mark] LIKE '{comboBox2.Text}'")[0].Id;
            int id = Convert.ToInt32(cars.Count + 1);
            string date_release = textBox3.Text;
            string name = textBox1.Text;
            string mark = textBox2.Text;
            string org = textBox4.Text;
            string colonna = textBox5.Text;
            string car_number = textBox7.Text;
            string motor_number = textBox8.Text;
            string kuzov_number = textBox9.Text;
            string tech_status = textBox10.Text;
            string max_speed = textBox11.Text;
            string oils_lost = textBox13.Text;

            string[] columns = new string[] { "Id", "[Name Car]", "[Marks]", "[Car Type]", "[Org]", "[Colonna]", "[Date release]", "[Car Number]", "[Motor Number]", "[Kuzov Number]", "[Tech Status]", "[Max Speed]", "[Oil Marks]", "[Oils Lost]" };
            List<string> values = new List<string>();
            values.Add($"'{name}'");
            values.Add($"'{mark}'");
            values.Add($"{car_typeId}");
            values.Add($"'{org}'");
            values.Add($"'{colonna}'");
            values.Add($"{date_release}");
            values.Add($"'{car_number}'");
            values.Add($"'{motor_number}'");
            values.Add($"'{kuzov_number}'");
            values.Add($"{tech_status}");
            values.Add($"{max_speed}");
            values.Add($"{oil_markrId}");
            values.Add($"{oils_lost}");


            dm.InsertValuses("Car", String.Join(",", columns), String.Join(",", values), id);
            MessageBox.Show("Новый тип успешно добавлен!");
            Close();
        }
    }
}
