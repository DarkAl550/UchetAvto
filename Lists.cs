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
        public Lists()
        {
            InitializeComponent();
            putLists = dl.GetPutLists();
            
        }

        private void Lists_Load(object sender, EventArgs e)
        {

        }
    }
}
