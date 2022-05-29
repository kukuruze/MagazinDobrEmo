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
    public partial class FormMotherBoardsShow : Form
    {
        public FormMotherBoardsShow()
        {
            InitializeComponent();
        }

        private void FormMotherBoardsShow_Load(object sender, EventArgs e)
        {
            List<MotherBoard> motherBoards = DataAccess.GetMotherBoards();
            richTextBox1.Text += "Mother Boards: \n";
            foreach (var item in motherBoards)
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
