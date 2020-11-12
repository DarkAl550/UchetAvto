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
        DataManager dm = new DataManager();
        public Lists()
        {
            InitializeComponent();
            putLists = dl.GetPutLists("");
            
        }

        private void Lists_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "№ Путевого листа";
            dataGridView1.Columns[1].Name = "Транспорт";
            dataGridView1.Columns[2].Name = "Водитель";
            dataGridView1.Columns[3].Name = "Дата Выезда";
            dataGridView1.Columns[4].Name = "Дата возврата";
            dataGridView1.Columns[5].Name = "Кол-во топлива при отправке";
            dataGridView1.Columns[6].Name = "Кол-во топлива по прибытию";
            dataGridView1.Columns[7].Name = "Маршрут";
            dataGridView1.Columns[8].Name = "Масса груза";
            string[] row;
            foreach (var l in putLists){
                List<DataObjects.Car> cars = dl.GetCars($"WHERE Id = {l.CarId}");
                List<DataObjects.Drivers> drivers = dl.GetDrivers($"WHERE Id = {l.DriverId}");
                List<DataObjects.Marshruts> marshruts = dl.GetMarshruts($"WHERE Id = {l.MarshrutId}");
                string carID = cars[0].Name_Car;
                string driverID = $" {drivers[0].LastName} {drivers[0].FirstName} {drivers[0].AfterName}";
                string marshrutID = $"{ marshruts[0].From} - {marshruts[0].To}";
                row = new string[] { l.Id,
                    carID,
                    driverID,
                    l.Date_Start, 
                    l.Date_End, 
                    l.Start_Oils, 
                    l.End_Oils,
                    marshrutID,
                    l.Mass};
                dataGridView1.Rows.Add(row);

            }
            

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            Close();
        }

        private void Lists_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main m = new Main();
            m.Show();
        }
    }
}
