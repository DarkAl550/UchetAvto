using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace UchetAvto
{
    public partial class CreateNew : Form
    {
        DataManager dm = new DataManager();
        DataLogic dl = new DataLogic();
        private List<string> values = new List<string>();
       // private List<string> columns = new List<string>();
        private string[] columns;
        
        public string tab;
        private List<DataObjects.Car_Type> car_Types = new List<DataObjects.Car_Type>();
        private List<DataObjects.Car> cars = new List<DataObjects.Car>();
        private List<DataObjects.Drivers> drivers = new List<DataObjects.Drivers>();
        private List<DataObjects.PutLists> lists = new List<DataObjects.PutLists>();
        private List<DataObjects.Oils> oils = new List<DataObjects.Oils>();
        private List<DataObjects.Marshruts> marshruts = new List<DataObjects.Marshruts>();
        private List<DataObjects.Oil_Marks> oil_Marks = new List<DataObjects.Oil_Marks>();
        private List<DataObjects.Users> users = new List<DataObjects.Users>();

        public CreateNew()
        {
            InitializeComponent();
        }

        private void CreateNew_Load(object sender, EventArgs e)
        {
            Text = "Добавление новой записи";
            label2.Text = $"Добавление: {tab}";
            switch (tab)
            {
                case "Тип транспорта":
                    label1.Visible = true;
                    label1.Text = "Тип авто";
                    break;
                case "Водители":
                    label1.Text = "Фамилия";
                    label3.Visible = true;
                    label3.Text = "Имя";
                    textBox2.Visible = true;
                    label4.Visible = true;
                    label4.Text = "Отчество";
                    textBox3.Visible = true;
                    label5.Visible = true;
                    label5.Text = "Дата рождения";
                    dateTimePicker1.Visible = true;
                    label6.Visible = true;
                    label6.Text = "Время работы";
                    textBox5.Visible = true;
                    label7.Visible = true;
                    label7.Text = "Зарплата";
                    textBox6.Visible = true;
                    label8.Visible = true;
                    label8.Text = "Категория прав";
                    textBox7.Visible = true;
                    break;
                case "Пользователи":
                    label1.Text = "Email";
                    label3.Visible = true;
                    label3.Text = "Пароль";
                    textBox2.Visible = true;
                    label4.Visible = true;
                    label4.Text = "Имя пользователя";
                    textBox3.Visible = true;
                    label5.Visible = true;
                    label5.Text = "Тип";
                    comboBox1.Visible = true;
                    comboBox1.Items.AddRange(new string[] { "Admin", "Manager", "Driver" });
                    comboBox1.SelectedIndex = 0;
                    break;
                default:
                    MessageBox.Show("Ошибка таблицы! Обратитесь к Администратору!");
                    Close();
                    break;
            }

        }
        #region AddData
        private void InsertCarTypes()
        {
            car_Types = dl.getCarTypes("");
            int id = Convert.ToInt32(car_Types[car_Types.Count - 1].Id) + 1;
            string type = textBox1.Text;
            columns = new string[] { "Id", "[Car Type]" };
            values.Add($"'{type}'");

            dm.InsertValuses("Car Type", String.Join(",", columns), String.Join(",", values), id);
            MessageBox.Show("Новый тип успешно добавлен!");
            Close();
        }
        private void InsertDrivers()
        {
            drivers = dl.GetDrivers("");
            int id = Convert.ToInt32(drivers.Count + 1);
            string lastname, firstname, aftername, dateborn, worktime, currency, category;//tb
            lastname = textBox1.Text;
            firstname = textBox2.Text;
            aftername = textBox3.Text;
            dateborn = dateTimePicker1.Value.ToString();
            worktime = textBox5.Text;
            currency = textBox6.Text;
            category = textBox7.Text;
            columns = new string[] { "Id", "LastName", "FirstName", "AfterName", "DateBorn", "WorkTime", "Currency", "Category" };
            values.Add($"'{lastname}'");
            values.Add($"'{firstname}'");
            values.Add($"'{aftername}'");
            values.Add($"'{dateborn}'");
            values.Add($"'{worktime}'");
            values.Add($"'{currency}'");
            values.Add($"'{category}'");
            dm.InsertValuses("Drivers", String.Join(",", columns), String.Join(",", values), id);
            MessageBox.Show("Новый Водитель успешно добавлен!");
            Close();


        }
        private void InsertUser()
        {
            users = dl.GetUsers("");
            int id = Convert.ToInt32(users.Count + 1);
            columns = new string[] { "Id", "Email", "Pass", "Username", "UserType" };
            string email, pass, username, usertype;
            email = textBox1.Text;
            pass = textBox2.Text;
            username = textBox3.Text;
            usertype = comboBox1.Text;
            values.Add($"'{email}'");
            values.Add($"'{pass}'");
            values.Add($"'{username}'");
            values.Add($"'{usertype}'");
            dm.InsertValuses("Users", String.Join(",", columns), String.Join(",", values), id);
            MessageBox.Show("Новый пользователь успешно добавлен!");
            Close();
        }

        private void InsertMarshrit()
        {

        }
        
        private void InsertCar()
        {
            cars = dl.GetCars("");
            int id = Convert.ToInt32(users.Count + 1);
            columns = new string[] { "Id", "Name Car", "Marks", "Car Type", "Org", "Colonna", "Date release", "Car Number", "Motor Number", "Kuzov Number", "Tech Status", "Max Speed", "Oil Marks", "Oils Lost" };
            string name_car, marks, car_type, org, colonna, date_release, car_number, motor_number, kuzov_number, tech_status, max_speed, oil_marks, oils_lost;
            name_car = textBox1.Text;
            marks = textBox2.Text;
            org = textBox3.Text;
            car_type = comboBox1.Text;
            colonna = checkBox1.Checked.ToString();
            values.Add($"'{name_car}'");
            values.Add($"'{marks}'");
            values.Add($"'{car_type}'");
            values.Add($"'{org}'");
            dm.InsertValuses("Users", String.Join(",", columns), String.Join(",", values), id);
            MessageBox.Show("Новый пользователь успешно добавлен!");
            Close();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tab)
                {
                    case "Тип транспорта": InsertCarTypes();break;
                    case "Водители": InsertDrivers();break;
                    case "Пользователи": InsertUser();break;
                    case "Транспорт": InsertCar();break;
                }
        }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Ошибка добавления новой записи");
            }

}

        private void CreateNew_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main m = new Main();
            m.Show();
            
        }
    }
}
