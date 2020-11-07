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
            
        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
            Lists l = new Lists();
            l.Show();
            Hide();
        }
    }
}
