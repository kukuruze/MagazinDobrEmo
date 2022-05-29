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
    public partial class FormSSDsShow : Form
    {
        public FormSSDsShow()
        {
            InitializeComponent();
        }

        private void FormSSDsShow_Load(object sender, EventArgs e)
        {
            List<SSD> ssds = DataAccess.GetSSDs();
            richTextBox1.Text += "SSDs: \n";
            foreach (var item in ssds)
            {
                richTextBox1.Text += $"ID: {item.Id}, Model: {item.Capacity}, Price: {item.Price}$ \n\n";
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
