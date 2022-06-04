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
    public partial class FormCart : Form
    {
        public FormCart()
        {
            InitializeComponent();
        }

        private void FormCart_Load(object sender, EventArgs e)
        {
            List<CPU> cpus;
            List<GPU> gpus;
            List<HDD> hdds;
            List<RAM> rams;
            List<SSD> ssds;
            List<MotherBoard> motherboards;
            decimal sum = 0;

            if(!(CurrentUser.Cart.cpu_id == null || CurrentUser.Cart.cpu_id == ""))
            {
                cpus = DataAccess.GetCPUs();
                var ids = CurrentUser.Cart.cpu_id.Split(',').ToList();
                var quants = CurrentUser.Cart.cpu_quantity.Split(',').ToList();
                for (int i = 0; i < ids.Count; i++)
                {
                    richTextBox1.Text += cpus[int.Parse(ids[i])-1].InfoNoPrice() + " x " + quants[i] + " = " + $"{cpus[int.Parse(ids[i])-1].Price * decimal.Parse(quants[i])} лв.\n";
                    sum += cpus[int.Parse(ids[i]) - 1].Price * decimal.Parse(quants[i]);
                }
            }
            if (!(CurrentUser.Cart.gpu_id == null || CurrentUser.Cart.gpu_id == ""))
            {
                gpus = DataAccess.GetGPUs();
                var ids = CurrentUser.Cart.gpu_id.Split(',').ToList();
                var quants = CurrentUser.Cart.gpu_quantity.Split(',').ToList();
                for (int i = 0; i < ids.Count; i++)
                {
                    richTextBox1.Text += gpus[int.Parse(ids[i])-1].InfoNoPrice() + " x " + quants[i] + " = " + $"{gpus[int.Parse(ids[i])-1].Price * decimal.Parse(quants[i])} лв.\n";
                    sum += gpus[int.Parse(ids[i]) - 1].Price * decimal.Parse(quants[i]);
                }
            }
            if (!(CurrentUser.Cart.hdd_id == null || CurrentUser.Cart.hdd_id == ""))
            {
                hdds = DataAccess.GetHDDs();
                var ids = CurrentUser.Cart.hdd_id.Split(',').ToList();
                var quants = CurrentUser.Cart.hdd_quantity.Split(',').ToList();
                for (int i = 0; i < ids.Count; i++)
                {
                    richTextBox1.Text += hdds[int.Parse(ids[i])-1].InfoNoPrice() + " x " + quants[i] + " = " + $"{hdds[int.Parse(ids[i])-1].Price * decimal.Parse(quants[i])} лв.\n";
                    sum += hdds[int.Parse(ids[i]) - 1].Price * decimal.Parse(quants[i]);
                }
            }
            if (!(CurrentUser.Cart.ram_id == null || CurrentUser.Cart.ram_id == ""))
            {
                rams = DataAccess.GetRAMs();
                var ids = CurrentUser.Cart.ram_id.Split(',').ToList();
                var quants = CurrentUser.Cart.ram_quantity.Split(',').ToList();
                for (int i = 0; i < ids.Count; i++)
                {
                    richTextBox1.Text += rams[int.Parse(ids[i])-1].InfoNoPrice() + " x " + quants[i] + " = " + $"{rams[int.Parse(ids[i])-1].Price * decimal.Parse(quants[i])} лв.\n";
                    sum += rams[int.Parse(ids[i]) - 1].Price * decimal.Parse(quants[i]);
                }
            }
            if (!(CurrentUser.Cart.ssd_id == null || CurrentUser.Cart.ssd_id == ""))
            {
                ssds = DataAccess.GetSSDs();
                var ids = CurrentUser.Cart.ssd_id.Split(',').ToList();
                var quants = CurrentUser.Cart.ssd_quantity.Split(',').ToList();
                for (int i = 0; i < ids.Count; i++)
                {
                    richTextBox1.Text += ssds[int.Parse(ids[i])-1].InfoNoPrice() + " x " + quants[i] + " = " + $"{ssds[int.Parse(ids[i])-1].Price * decimal.Parse(quants[i])} лв.\n";
                    sum += ssds[int.Parse(ids[i]) - 1].Price * decimal.Parse(quants[i]);
                }
            }
            if (!(CurrentUser.Cart.mother_board_id == null || CurrentUser.Cart.mother_board_id == ""))
            {
                motherboards = DataAccess.GetMotherBoards();
                var ids = CurrentUser.Cart.mother_board_id.Split(',').ToList();
                var quants = CurrentUser.Cart.mother_board_quantity.Split(',').ToList();
                for (int i = 0; i < ids.Count; i++)
                {
                    richTextBox1.Text += motherboards[int.Parse(ids[i])-1].InfoNoPrice() + " x " + quants[i] + " = " + $"{motherboards[int.Parse(ids[i])-1].Price * decimal.Parse(quants[i])} лв.\n";
                    sum += motherboards[int.Parse(ids[i]) - 1].Price * decimal.Parse(quants[i]);
                }
            }
            richTextBox1.Text += $"Цялата сума на артикулите е: {sum:F2} лв.";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cart emptyCart = new Cart(CurrentUser.Cart.cart_id);
            CurrentUser.Cart = emptyCart;
            DataAccess.UpdateCart();
            MessageBox.Show("Количката бе изчистена!");
            richTextBox1.Clear();
            FormCart_Load(sender, e);

        }

        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            Cart emptyCart = new Cart(CurrentUser.Cart.cart_id);
            CurrentUser.Cart = emptyCart;
            DataAccess.UpdateCart();
            MessageBox.Show("Направихте поръчка!");
            MessageBox.Show("Благодарим Ви, че се доверихте на Магазин \"ДобрЕмо!\"");
            Application.Exit();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Hide();
            new FormStoreStart().Show();
        }
    }
}
