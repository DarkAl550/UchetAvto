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
    public partial class Main : Form
    {
        public string TYPE;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            label6.Text = TYPE;
            if(TYPE == "Driver")
            {
                button1.Visible = false;
                label5.Visible = false;
                linkLabel5.Visible = false;
                label2.Visible = false;
                linkLabel2.Visible = false;
                btnViewDrivers.Visible = false;
            }
            else if(TYPE == "Manager")
            {
                button1.Visible = false;
                label5.Visible = false;
                linkLabel5.Visible = false;
            }
            
        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
            Lists l = new Lists();
            l.Show();
            Hide();
        }

        private void btnViewDrivers_Click(object sender, EventArgs e)
        {
            Drivers d = new Drivers();
            d.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransportType tt = new TransportType();
            tt.Show();
            Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateNew cn = new CreateNew();
            cn.tab = "Путевые листы";
            cn.Show();
            Hide();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateNew cn = new CreateNew();
            cn.tab = "Водители";
            cn.Show();
            Hide();

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateNew cn = new CreateNew();
            cn.tab = "Маршруты";
            cn.Show();
            Hide();

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateNew cn = new CreateNew();
            cn.tab = "Тип транспорта";
            cn.Show();
            Hide();

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateNew cn = new CreateNew();
            cn.tab = "Пользователи";
            cn.Show();
            Hide();

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Users u = new Users();
            u.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transport t = new Transport();
            t.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа UchetAvto разработана для учета автотранспортных средств.\nДля отображения необходимых данных неообходимо нажать кнопку \"Показать\" под соответствующим указанием.\nДля создания новой записи в таблице необходимо нажать на кнопку \"Создать\" или \"Добавить\" под сопутствующим указанием.\nПриятного пользования!","Помощь");

        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateNew cn = new CreateNew();
            cn.tab = "Транспорт";
            cn.Show();
            Hide();
        }

        private void btnViewMarshruts_Click(object sender, EventArgs e)
        {
            Marshruts m = new Marshruts();
            m.Show();
            Hide();
        }
    }
}
