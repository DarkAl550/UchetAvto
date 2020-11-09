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
    public partial class CreateNew : Form
    {
        DataManager dm = new DataManager();
        DataLogic dl = new DataLogic();
        private List<string> values = new List<string>();
        private List<string> columns = new List<string>();
        
        public string tab;
        private List<DataObjects.Car_Type> car_Types = new List<DataObjects.Car_Type>();
        private List<DataObjects.Car> cars = new List<DataObjects.Car>();
        private List<DataObjects.Drivers> drivers = new List<DataObjects.Drivers>();
        private List<DataObjects.PutLists> lists = new List<DataObjects.PutLists>();
        private List<DataObjects.Oils> oils = new List<DataObjects.Oils>();
        private List<DataObjects.Marshruts> marshruts = new List<DataObjects.Marshruts>();
        private List<DataObjects.Oil_Marks> oil_Marks = new List<DataObjects.Oil_Marks>();

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
            columns.Add("Id");
            columns.Add("[Car Type]");
            values.Add($"'{type}'");

            dm.InsertValuses("Car Type", String.Join(",", columns), String.Join(",", values), id);
            MessageBox.Show("Новый тип успешно добавлен!");
            Hide();
        }

        
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tab)
                {
                    case "Тип транспорта": InsertCarTypes();break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка добавления новой записи");
            }
            
        }

        private void CreateNew_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main m = new Main();
            m.Enabled = true;
        }
    }
}
