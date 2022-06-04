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
            if (textBoxFullName.Text == "" || textBoxUserName.Text == "" || textBoxEmail.Text == "" || textBoxPassword.Text == "" || textBoxConfirmPassword.Text == "")
            {
                MessageBox.Show("Грешка! Някое от полетата не е запълнено!");
                return;
            }
            string username = textBoxUserName.Text;
            username = DataModifier.CyrillicToLatin(username);
            string email = textBoxEmail.Text;
            if(DataAccess.IsSomethingAlreadyInDatabase("Username", username))
            {
                MessageBox.Show("Грешка! Псевдонимът вече е зает!");
                return;
            }
            if (DataAccess.IsSomethingAlreadyInDatabase("Email", email))
            {
                MessageBox.Show("Грешка! Имейлът вече е зает!");
                return;
            }   
            if(textBoxPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Грешка! Паролите не съвпадат!");
                return;
            }
            Client newClient = new Client(username, email, DataModifier.CyrillicToLatin(textBoxPassword.Text), DataModifier.CyrillicToLatin(textBoxFullName.Text), DataAccess.GetNewCartId());
            Cart newCart = new Cart(DataAccess.GetNewCartId());
            DataAccess.AddNewClientToDatabase(newClient);
            DataAccess.AddNewCartToDatabase(newCart);
            CurrentUser.Client = DataAccess.GetSpecificClient("Username", username)[0];
            CurrentUser.Cart = DataAccess.GetCartById(CurrentUser.Client.Cart_id);
            MessageBox.Show("Регистрацията е успешна!");
            Hide();
            new FormStoreStart().Show();
        }
    }
}
