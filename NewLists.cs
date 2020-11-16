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
        List<DataObjects.Car> car = new List<DataObjects.Car>();
        List<DataObjects.Drivers> driver = new List<DataObjects.Drivers>();
        List<DataObjects.Marshruts> marshrut = new List<DataObjects.Marshruts>();
        List<DataObjects.PutLists> lists = new List<DataObjects.PutLists>();
        DataLogic dl = new DataLogic();
        DataManager dm = new DataManager();

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
                cars[i] = car[i].Name_Car;
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
            lists = dl.GetPutLists("");
            string carId = dl.GetCars($"WHERE [Name Car] LIKE '{comboBox1.Text}'")[0].Id;
            string driverId = dl.GetDrivers($"WHERE [LastName] LIKE '{comboBox2.Text.Split(' ')[0]}' AND [FirstName] LIKE '{comboBox2.Text.Split(' ')[1]}'")[0].Id;
            string marshrutId = dl.GetMarshruts($"WHERE [From] LIKE '{comboBox3.Text.Split('-')[0]}' AND [To] LIKE '{comboBox3.Text.Split('-')[1]}'")[0].Id;
            int id = Convert.ToInt32(lists.Count + 1);
            string date_start = dateTimePicker1.Value.ToString();
            string date_end = dateTimePicker2.Value.ToString();
            string start_oils = textBox1.Text;
            string end_oils = textBox2.Text;
            string mass = textBox3.Text;
            string[] columns = new string[] { "Id", "[Car]", "[Driver]", "[Date Start]", "[Date End]", "[Start Oils]", "[End Oils]", "[Marshrut]", "[Mass]" };
            List<string> values = new List<string>();
            values.Add($"{carId}");
            values.Add($"{driverId}");
            values.Add($"'{date_start}'");
            values.Add($"'{date_end}'");
            values.Add($"'{start_oils}'");  
            values.Add($"'{end_oils}'");
            values.Add($"{marshrutId}");
            values.Add($"'{mass}'");


            dm.InsertValuses("Lists", String.Join(",", columns), String.Join(",", values), id);
            MessageBox.Show("Новый тип успешно добавлен!");
            Close();
        }

        private void NewLists_Load(object sender, EventArgs e)
        {
            string[] listCars = GetCars();
            string[] listDrivers = GetDrivers();
            string[] listMarshruts = GetMarshruts();
            comboBox1.Items.AddRange(listCars);
            comboBox2.Items.AddRange(listDrivers);
            comboBox3.Items.AddRange(listMarshruts);
        }
    }
}
