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
    public partial class NewLists : Form
    {
        private string[] listCars;
        private string[] listDrivers;
        private string[] listMarshruts;
        List<DataObjects.Car> car = new List<DataObjects.Car>();
        List<DataObjects.Drivers> driver = new List<DataObjects.Drivers>();
        List<DataObjects.Marshruts> marshrut = new List<DataObjects.Marshruts>();
        List<DataObjects.PutLists> lists = new List<DataObjects.PutLists>();
        DataLogic dl = new DataLogic();
        DataManager dm = new DataManager();
        Validate valid = new Validate();
        public NewLists()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void NewLists_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main m = new Main();
            m.Show();
        }

        private string[] GetCars()
        {
            
            car = dl.GetCars("");
            string[] cars = new string[car.Count];
            for (int i = 0; i < car.Count; i++)
            {
                cars[i] = $"{car[i].Name_Car} ({car[i].Car_Number})";
            }
            
            return cars;
        }
        private string[] GetDrivers()
        {
            
            driver = dl.GetDrivers("");
            string[] drivers = new string[driver.Count];
            for (int i = 0; i < driver.Count; i++)
            {
                drivers[i] = $"{driver[i].LastName} {driver[i].FirstName}";
            }
            return drivers;
        }
        private string[] GetMarshruts()
        {
            
            marshrut = dl.GetMarshruts("");
            string[] marshruts = new string[marshrut.Count];
            for (int i = 0; i < marshrut.Count; i++)
            {
                marshruts[i] = $"{marshrut[i].From}-{marshrut[i].To}";
            }
            return marshruts;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lists = dl.GetPutLists("");
                string carId = (valid.CheckComboBoxValue(listCars, comboBox1.Text) == null) ? 
                    throw new Exception($"Значения \"{comboBox1.Text}\" не существует в контексте \"Транспорт\"") 
                    : dl.GetCars($"WHERE [Name Car] LIKE '{comboBox1.Text.Split(' ')[0]}'")[0].Id;
                string driverId = (valid.CheckComboBoxValue(listDrivers, comboBox2.Text) == null) ? 
                    throw new Exception($"Значения \"{comboBox2.Text}\" не существует в контексте \"Водитель\"") 
                    : dl.GetDrivers($"WHERE [LastName] LIKE '{comboBox2.Text.Split(' ')[0]}' AND [FirstName] LIKE '{comboBox2.Text.Split(' ')[1]}'")[0].Id;
                string marshrutId = (valid.CheckComboBoxValue(listMarshruts, comboBox3.Text) == null) ? 
                    throw new Exception($"Значения \"{comboBox3.Text}\" не существует в контексте \"Маршрут\"") 
                    : dl.GetMarshruts($"WHERE [From] LIKE '{comboBox3.Text.Split('-')[0]}' AND [To] LIKE '{comboBox3.Text.Split('-')[1]}'")[0].Id;
                int id = Convert.ToInt32(lists.Count + 1);
                string date_start = dateTimePicker1.Value.ToString();
                string date_end = dateTimePicker2.Value.ToString();
                string start_oils = (valid.CheckNumFields(textBox1.Text) == null) ? 
                    throw new Exception("Неверный формат поля \"Начальное количество топлива\""+
                    "\n**поле может содержать только численное значение**\nПример: [120.0]") : textBox1.Text;
                string end_oils = (valid.CheckNumFields(textBox2.Text) == null) ? 
                    throw new Exception("Неверный формат поля \"Конечное количество топлива\"" +
                    "\n**поле может содержать только численное значение**\nПример: [120.0]") : textBox2.Text;
                string mass = (valid.CheckNumFields(textBox2.Text) == null) ? 
                    throw new Exception("Неверный формат поля \"Масса\"" +
                    "\n**поле может содержать только численное значение**\nПример: [20000]") : textBox3.Text;
                string[] columns = new string[] { 
                    "Id", 
                    "[Car]", 
                    "[Driver]", 
                    "[Date Start]", 
                    "[Date End]", 
                    "[Start Oils]", 
                    "[End Oils]", 
                    "[Marshrut]", 
                    "[Mass]" 
                };
                List<string> values = new List<string>
                {
                    $"{carId}",
                    $"{driverId}",
                    $"'{date_start}'",
                    $"'{date_end}'",
                    $"'{start_oils}'",
                    $"'{end_oils}'",
                    $"{marshrutId}",
                    $"'{mass}'"
                };


                dm.InsertValuses("Lists", String.Join(",", columns), String.Join(",", values), id);
                MessageBox.Show("Новый \"Путевой лист\" успешно добавлен!");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewLists_Load(object sender, EventArgs e)
        {
            listCars = GetCars();
            listDrivers = GetDrivers();
            listMarshruts = GetMarshruts();
            comboBox1.Items.AddRange(listCars);
            comboBox2.Items.AddRange(listDrivers);
            comboBox3.Items.AddRange(listMarshruts);
        }
    }
}
