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
    public partial class FormCPUsShow : Form
    {
        public FormCPUsShow()
        {
            InitializeComponent();
        }

        private void FormCPUsShow_Load(object sender, EventArgs e)
        {
            List<CPU> cpus = DataAccess.GetCPUs();
            richTextBox1.Text += "CPUs: \n";
            foreach (var item in cpus)
            {
                richTextBox1.Text += $"ID: {item.cpu_id}, Model: {item.cpu_model}, Price: {item.cpu_price}$ \n\n";
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
