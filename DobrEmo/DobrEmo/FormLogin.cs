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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text;
            username = DataModifier.CyrillicToLatin(username);
            if(!DataAccess.IsSomethingAlreadyInDatabase("Username",username))
            {
                MessageBox.Show("Невалидни входни данни! Моля опитайте отново!");
                return;
            }

            string password = textBoxPassword.Text;
            var output = DataAccess.GetSpecificClientInfo("Username", username, "Password").First();
            if(output == password)
            {
                MessageBox.Show("Успешно влизане в системата!");
                Hide();
                new FormStoreStart().Show();
            }
            else
            {
                MessageBox.Show("Невалидни входни данни! Моля опитайте отново!");
                return;
            }

            CurrentUser.CurrentClient = DataAccess.GetSpecificClient("Username", username)[0];

            MessageBox.Show($"Current user is {CurrentUser.CurrentClient.Fullname}");
        }

        private void labelNoAccount_Click(object sender, EventArgs e)
        {
            Hide();
            new FormStart().Show();
        }

        private void labelForgotPassword_Click(object sender, EventArgs e)
        {
            Hide();
            new FormForgotPassword().Show();
        }
    }
}
