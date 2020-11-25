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
            try
            {
                marshruts = DataLogic.GetMarshruts("");
                int id = Convert.ToInt32(marshruts.Count + 1);
                string from = (Valid.TextValid(textBox1.Text) == null) ? 
                    throw new Exception("Неверный формат поля \"Откуда\"" +
                    "\n**поле не должно содержать цифры и символы**\nПример: [Минск]") : textBox1.Text;
                string to = (Valid.TextValid(textBox2.Text) == null) ? 
                    throw new Exception("Неверный формат поля \"Куда\"" +
                    "\n**поле не должно содержать цифры и символы**\nПример: [Минск]") : textBox2.Text;
                string date_start = dateTimePicker1.Value.ToString();
                string date_end = dateTimePicker2.Value.ToString();
                string length = (Valid.CheckNumFields(textBox3.Text) == null) ? 
                    throw new Exception("Неверный формат поля \"Длительность\"" +
                    "\n**поле должно содержать только численное значение**\nПример: [8]") : textBox3.Text;
                string oils_lost = (Valid.CheckNumFields(textBox4.Text) == null) ? 
                    throw new Exception("Неверный формат поля \"Приблизительный расход топлива\"" +
                    "\n**поле должно содержать только численное значение**\nПример: [8.89]") : textBox4.Text;
                string time_to_sleep = (Valid.CheckTimeField(textBox5.Text) == null) ? 
                    throw new Exception("Неверный формат поля \"Время на сон\"" +
                    "\n**поле должно содержать только значение времени**\nПример: [12:00]") : textBox5.Text;
                string[] columns = new string[] {
                    "Id", 
                    "[From]",
                    "[To]",
                    "[Date Start]",
                    "[Date End]",
                    "[Length]",
                    "[Oils lost]",
                    "[Time to sleep]" };
                List<string> values = new List<string>
                {
                    $"'{from}'",
                    $"'{to}'",
                    $"'{date_start}'",
                    $"'{date_end}'",
                    $"'{length}'",
                    $"'{oils_lost}'",
                    $"'{time_to_sleep}'"
                };
                DataManager.InsertValuses("Marshruts", String.Join(",", columns), String.Join(",", values), id);
                MessageBox.Show("Новый \"Маршрут\" успешно добавлен!");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void NewMarshrut_Load(object sender, EventArgs e)
        {
            
        }
    }
}
