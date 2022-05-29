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
    public partial class FormHardDrivesShow : Form
    {
        public FormHardDrivesShow()
        {
            InitializeComponent();
        }

        private void FormHardDrivesShow_Load(object sender, EventArgs e)
        {
            List<HDD> hdds = DataAccess.GetHDDs();
            richTextBox1.Text += "HDDs: \n";
            foreach (var item in hdds)
            {
                richTextBox1.Text += $"ID: {item.hdd_id}, Capacity: {item.hdd_capacity} TB, Price: {item.hdd_price}$ \n\n";
            }
        }

        private void buttonToStoreStart_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            new FormStoreStart().Show();
            Hide();
        }
    }
}
