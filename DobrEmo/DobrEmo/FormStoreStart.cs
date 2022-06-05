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
            new FormSpecShow("HDD").Show();
            Hide();
        }

        private void buttonCPUsShow_Click(object sender, EventArgs e)
        {
            new FormSpecShow("CPU").Show();
            Hide();
        }

        private void buttonGPUsShow_Click(object sender, EventArgs e)
        {
            new FormSpecShow("GPU").Show();
            Hide();
        }

        private void buttonMotherBoardsShow_Click(object sender, EventArgs e)
        {
            new FormSpecShow("Motherboard").Show();
            Hide();
        }

        private void buttonRAMsShow_Click(object sender, EventArgs e)
        {
            new FormSpecShow("RAM").Show();
            Hide();
        }
        private void buttonSSDsShow_Click(object sender, EventArgs e)
        {
            new FormSpecShow("SSD").Show();
            Hide();
        }

        private void buttonExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            new FormCart().Show();
            Hide();
        }

        private void FormStoreStart_Load(object sender, EventArgs e)
        {
            labelUser.Text = $"Потребител: {DataAccess.GetSpecificClient("Username", CurrentUser.Client.Username)[0].Fullname}";
        }
    }
}
