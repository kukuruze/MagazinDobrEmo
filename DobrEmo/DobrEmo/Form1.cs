using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DobrEmo
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            List<HDD> hdds = DataAccess.GetHDDs();
            foreach (var item in hdds)
            {
                richTextBox1.Text += item.hdd_id + " " + item.hdd_capacity + " " + item.hdd_price + "\n";
            }
        }
    }
}
