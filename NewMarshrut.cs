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
    
    public partial class NewMarshrut : Form
    {
        public string tab;
        DataLogic dl = new DataLogic();
        DataManager dm = new DataManager();
        List<DataObjects.Marshruts> marshruts = new List<DataObjects.Marshruts>();

        public NewMarshrut()
        {
            InitializeComponent();
        }

        private void NewMarshrut_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main m = new Main();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            marshruts = dl.GetMarshruts("");
            int id = Convert.ToInt32(marshruts.Count + 1);
            string from = textBox1.Text;
            string to = textBox2.Text;
            string date_start = dateTimePicker1.Value.ToString();
            string date_end = dateTimePicker2.Value.ToString();
            string length = textBox3.Text;
            string oils_lost = textBox4.Text;
            string time_to_sleep = textBox5.Text;
            string[] columns = new string[] { "Id", "[From]", "[To]", "[Date Start]", "[Date End]", "[Length]","[Oils lost]","[Time to sleep]" };
            List<string> values = new List<string>();
            values.Add($"'{from}'");
            values.Add($"'{to}'");
            values.Add($"'{date_start}'");
            values.Add($"'{date_end}'");
            values.Add($"'{length}'");
            values.Add($"'{oils_lost}'");
            values.Add($"'{time_to_sleep}'");
            

            dm.InsertValuses("Marshruts", String.Join(",", columns), String.Join(",", values), id);
            MessageBox.Show("Новый тип успешно добавлен!");
            Close();
        }

        private void NewMarshrut_Load(object sender, EventArgs e)
        {
            
        }
    }
}
