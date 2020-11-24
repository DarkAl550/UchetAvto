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
        Validate valid = new Validate();
        private string[] columns;
        public string tab;
        private string[] cb1Values = { "Admin", "Manager", "Driver" };
        private List<DataObjects.Car_Type> car_Types = new List<DataObjects.Car_Type>();
        private List<DataObjects.Drivers> drivers = new List<DataObjects.Drivers>();
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
                    comboBox1.Items.AddRange(cb1Values);
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
            try
            {
                car_Types = dl.getCarTypes("");
                int id = Convert.ToInt32(car_Types[car_Types.Count - 1].Id) + 1;
                string type = (valid.TextValid(textBox1.Text) == null) ? 
                    throw new Exception("Неверный формат поля \"Тип транспорта\"" +
                    "\n**поле не должно содержать цифры и символы**\nПример: [Грузовой]") : textBox1.Text;
                columns = new string[] { "Id", "[Car Type]" };
                List<string> values = new List<string>
                {
                    $"'{type}'"
                };

                dm.InsertValuses("Car Type", String.Join(",", columns), String.Join(",", values), id);
                MessageBox.Show("Новый \"Тип транспорта\" успешно добавлен!");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void InsertDrivers()
        {
            try
            {
                drivers = dl.GetDrivers("");
                int id = Convert.ToInt32(drivers.Count + 1);
                string lastname, firstname, aftername, dateborn, worktime, currency, category;//tb
                lastname = (valid.TextValid(textBox1.Text) == null) ? 
                    throw new Exception("Неверный формат поля \"Фамилия\"" +
                    "\n**поле не должно содержать цифры и символы**\nПример: [Иванов]") : textBox1.Text;
                firstname = (valid.TextValid(textBox2.Text) == null) ? 
                    throw new Exception("Неверный формат поля \"Имя\"" +
                    "\n**поле не должно содержать цифры и символы**\nПример: [Иван]") : textBox2.Text;
                aftername = (valid.TextValid(textBox3.Text) == null) ? 
                    throw new Exception("Неверный формат поля \"Отчество\"" +
                    "\n**поле не должно содержать цифры и символы**\nПример: [Иванович]") : textBox3.Text;
                dateborn = dateTimePicker1.Value.ToString();
                worktime = (valid.CheckNumFields(textBox5.Text) == null) ? 
                    throw new Exception("Неверный формат поля \"Рабочее время\"" +
                    "\n**поле должно содержать численное значение**\nПример: [8]") : textBox5.Text;
                currency = (valid.CheckNumFields(textBox6.Text) == null) ? 
                    throw new Exception("Неверный формат поля \"Зарплата\"" +
                    "\n**поле должно содержать численное значение**\nПример: [2000.5]") : textBox6.Text;
                category = (valid.TextValid(textBox7.Text) == null) ? 
                    throw new Exception("Неверный формат поля \"Категория\"" +
                    "\n**поле не должно содержать цифры и символы**\nПример: [C]") : textBox7.Text;
                columns = new string[] { "Id", 
                    "LastName",
                    "FirstName",
                    "AfterName", 
                    "DateBorn",
                    "WorkTime",
                    "Currency",
                    "Category" 
                };
                List<string> values = new List<string>
                {
                    $"'{lastname}'",
                    $"'{firstname}'",
                    $"'{aftername}'",
                    $"'{dateborn}'",
                    $"'{worktime}'",
                    $"'{currency}'",
                    $"'{category}'"
                };
                dm.InsertValuses("Drivers", String.Join(",", columns), String.Join(",", values), id);
                MessageBox.Show("Новый \"Водитель\" успешно добавлен!");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void InsertUser()
        {
            try
            {
                users = dl.GetUsers("");
                int id = Convert.ToInt32(users.Count + 1);
                columns = new string[] { "Id", "Email", "Pass", "Username", "UserType" };
                string email, pass, username, usertype;
                email = (valid.CheckEmail(textBox1.Text) == null) ? 
                    throw new Exception("Неверный формат поля \"Email\"" +
                    "\n**поле должно содержать '@' и '.'**\nПример: [example@example.exp]") : textBox1.Text;
                pass = textBox2.Text;
                username = (valid.CheckNewUsername(textBox3.Text) == null) ? 
                    throw new Exception("Неверный формат поля \"Имя пользователя\"" +
                    "\n**поле не должно содержать символы**\nПример: [user123]") : textBox3.Text;
                usertype = (valid.CheckComboBoxValue(cb1Values, comboBox1.Text) == null) ? 
                    throw new Exception("Данного \"Типа пользователя\" не существует") : comboBox1.Text;
                List<string> values = new List<string>
                {
                    $"'{email}'",
                    $"'{pass}'",
                    $"'{username}'",
                    $"'{usertype}'"
                };
                dm.InsertValuses("Users", String.Join(",", columns), String.Join(",", values), id);
                MessageBox.Show("Новый \"Пользователь\" успешно добавлен!");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
