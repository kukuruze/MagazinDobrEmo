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

        private void labelGoToLogin_Click(object sender, EventArgs e)
        {
            Hide();
            new FormLogin().Show();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text;
            if(DataAccess.IsUsernameAlreadyInDatabase(username))
            {
                throw new ArgumentException("Username already in database");
            }
            else
            {
                //add to database
            }
            Hide();
            new FormStoreStart().Show();
        }
    }
}
