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
    public partial class FormForgotPassword : Form
    {
        string email;
        string newPassword;
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private void buttonAdvance_Click(object sender, EventArgs e)
        {
            if (labelTextDisplayed.Text == "Имейл")
            {
                email = textBoxInput.Text;
                if(!DataAccess.IsSomethingAlreadyInDatabase("Email", email))
                {
                    MessageBox.Show("Грешка! Няма регистрация на този имейл!");
                    return;
                }
                textBoxInput.Clear();
                labelTextDisplayed.Text = "Нова парола";
                textBoxInput.UseSystemPasswordChar = true;
            }
            else
            {
                newPassword = textBoxInput.Text;
                textBoxInput.Clear();
                labelTextDisplayed.Text = "Имейл";
                textBoxInput.UseSystemPasswordChar = false;
                DataAccess.UpdatePassword(newPassword, email);
                Hide();
                MessageBox.Show("Паролата е успешно променена");
                new FormLogin().Show();
            }
        }
    }
}
