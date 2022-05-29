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
    public partial class FormStoreStart : Form
    {
        public FormStoreStart()
        {
            InitializeComponent();
        }

        private void buttonHardDrivesShow_Click(object sender, EventArgs e)
        {
            new FormHardDrivesShow().Show();
            Hide();
        }

        private void buttonCPUsShow_Click(object sender, EventArgs e)
        {
            new FormCPUsShow().Show();
            Hide();
        }

        private void buttonGPUsShow_Click(object sender, EventArgs e)
        {
            new FormGPUsShow().Show();
            Hide();
        }

        private void buttonMotherBoardsShow_Click(object sender, EventArgs e)
        {
            new FormMotherBoardsShow().Show();
            Hide();
        }

        private void buttonRAMsShow_Click(object sender, EventArgs e)
        {
            new FormRAMsShow().Show();
            Hide();
        }
        private void buttonSSDsShow_Click(object sender, EventArgs e)
        {
            new FormSSDsShow().Show();
            Hide();
        }

        private void buttonExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
