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
    public partial class FormRAMsShow : Form
    {
        public FormRAMsShow()
        {
            InitializeComponent();
        }

        private void FormRAMsShow_Load(object sender, EventArgs e)
        {
            List<RAM> rams = DataAccess.GetRAMs();
            richTextBox1.Text += "RAMs: \n";
            foreach (var item in rams)
            {
                richTextBox1.Text += $"ID: {item.ram_id}, Capacity: {item.ram_capacity} GB, Price: {item.ram_price}$ \n\n";
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
