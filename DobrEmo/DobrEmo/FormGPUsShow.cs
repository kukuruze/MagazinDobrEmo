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
    public partial class FormGPUsShow : Form
    {
        public FormGPUsShow()
        {
            InitializeComponent();
        }

        private void FormGPUsShow_Load(object sender, EventArgs e)
        {
            List<GPU> gpus = DataAccess.GetGPUs();
            richTextBox1.Text += "GPUs: \n";
            foreach (var item in gpus)
            {
                richTextBox1.Text += $"ID: {item.Id}, Model: {item.Model}, Price: {item.Price}$ \n\n";
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
