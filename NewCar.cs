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
        private string[] listTypes;
        private string[] listMarks;
        private List<DataObjects.Car> cars = new List<DataObjects.Car>();
        private List<DataObjects.Car_Type> car_types = new List<DataObjects.Car_Type>();
        private List<DataObjects.Oil_Marks> oil_marks = new List<DataObjects.Oil_Marks>();
        private Validate valid = new Validate();
        private DataLogic dl = new DataLogic();
        private DataManager dm = new DataManager();

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
            listTypes = GetCarType();
            listMarks = GetOilsMarks();
            comboBox1.Items.AddRange(listTypes);
            comboBox2.Items.AddRange(listMarks);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cars = dl.GetCars("");
                string car_typeId = (valid.CheckComboBoxValue(listTypes, comboBox1.Text) == null) ? 
                    throw new Exception("Данного \"Типа транспорта\" не существует") 
                    : dl.getCarTypes($"WHERE [Car Type] LIKE '{comboBox1.Text}'")[0].Id;
                string oil_markrId = (valid.CheckComboBoxValue(listMarks, comboBox2.Text) == null) ? 
                    throw new Exception("Данной \"Марки топлива\" не существует") 
                    : dl.GetOilsMarks($"WHERE [Oil Mark] LIKE '{comboBox2.Text}'")[0].Id;
                int id = Convert.ToInt32(cars.Count + 1);
                string date_release = (valid.CheckNumFields(textBox3.Text) == null) ? 
                    throw new Exception("Неверный формат поля \"Год изготовления\"" +
                    "\n**поле может содержать только целочисенное значение**\nПример: [1990]") : textBox3.Text;
                string name = (valid.TextValid(textBox1.Text) == null) ? 
                    throw new Exception("Неверный формат поля \"Название транспорта\"" +
                    "\n**поле не должно содержать цифры и символы**\nПример: [ВАЗ]") : textBox1.Text;
                string mark = textBox2.Text;
                string org = (valid.TextValid(textBox4.Text) == null) ? 
                    throw new Exception("Неверный формат поля \"Организации\"" +
                    "\n**поле не должно содержать цифры и символы**\nПример: [КарТранспорт]") : textBox4.Text;
                string colonna = textBox5.Text;
                string car_number = textBox7.Text;
                string motor_number = textBox8.Text;
                string kuzov_number = textBox9.Text;
                string tech_status = (valid.CheckNumFields(textBox10.Text) == null) ? 
                    throw new Exception("Неверный формат поля \"Техническое состояние\"" +
                    "\n**поле должно иметь значение от 0 до 100**\nПример: [90.5]") : textBox10.Text;
                string max_speed = (valid.CheckNumFields(textBox11.Text) == null) ? 
                    throw new Exception("Неверный формат поля \"Максимальная скорость\"" +
                    "\n**поле может содержать только целочисенное значение**\nПример: [120]") : textBox11.Text;
                string oils_lost = (valid.CheckNumFields(textBox13.Text) == null) ? 
                    throw new Exception("Неверный формат поля \"Расход топлива\"" +
                    "\n**поле может содержать только численное значение**\nПример: [18.0]") : textBox13.Text;

                string[] columns = new string[] { 
                    "Id", 
                    "[Name Car]", 
                    "[Marks]", 
                    "[Car Type]", 
                    "[Org]", 
                    "[Colonna]",
                    "[Date release]", 
                    "[Car Number]",
                    "[Motor Number]",
                    "[Kuzov Number]",
                    "[Tech Status]",
                    "[Max Speed]", 
                    "[Oil Marks]", 
                    "[Oils Lost]"
                };
                List<string> values = new List<string>
                {
                    $"'{name}'",
                    $"'{mark}'",
                    $"{car_typeId}",
                    $"'{org}'",
                    $"'{colonna}'",
                    $"{date_release}",
                    $"'{car_number}'",
                    $"'{motor_number}'",
                    $"'{kuzov_number}'",
                    $"{tech_status}",
                    $"{max_speed}",
                    $"{oil_markrId}",
                    $"{oils_lost}"
                };
                dm.InsertValuses("Car", String.Join(",", columns), String.Join(",", values), id);
                MessageBox.Show("Новый \"Транспорт\" успешно добавлен!");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
