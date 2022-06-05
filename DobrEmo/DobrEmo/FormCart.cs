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
                    comboBox1.Items.Add(cpus[int.Parse(ids[i]) - 1].InfoNoPrice());
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
                    comboBox1.Items.Add(gpus[int.Parse(ids[i]) - 1].InfoNoPrice());
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
                    comboBox1.Items.Add(hdds[int.Parse(ids[i]) - 1].InfoNoPrice());
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
                    comboBox1.Items.Add(rams[int.Parse(ids[i]) - 1].InfoNoPrice());
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
                    comboBox1.Items.Add(ssds[int.Parse(ids[i]) - 1].InfoNoPrice());
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
                    comboBox1.Items.Add(motherboards[int.Parse(ids[i]) - 1].InfoNoPrice());
                }
            }
            richTextBox1.Text += $"Цялата сума на артикулите е: {sum:F2} лв.";

            /*string a = "";
            foreach (var item in Program.cartItems)
            {
                a += $"{item}\n";
            }
            MessageBox.Show(a);*/
            //MessageBox.Show(Program.cartItems.Count.ToString());
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

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            var itemInfo = comboBox1.Text.Split(' ').ToList();
            string type = itemInfo[0];
            int index = int.Parse(itemInfo[1][1].ToString());
            int quantityToAdd = Convert.ToInt32(numericUpDown1.Value);

            switch (type)
            {
                case "HDD":
                    {
                        var ids = CurrentUser.Cart.hdd_id.Split(',').ToList();
                        var indexInTable = ids.IndexOf(index.ToString());
                        var quantities = CurrentUser.Cart.hdd_quantity.Split(',').ToList();
                        quantities[indexInTable] = (int.Parse(quantities[indexInTable]) + quantityToAdd).ToString();
                        CurrentUser.Cart.hdd_quantity = string.Join(",", quantities);
                        DataAccess.UpdateCart();
                        Close();
                        new FormCart().Show();
                    }
                    break;
                case "CPU":
                    {
                        var ids = CurrentUser.Cart.cpu_id.Split(',').ToList();
                        var indexInTable = ids.IndexOf(index.ToString());
                        var quantities = CurrentUser.Cart.cpu_quantity.Split(',').ToList();
                        quantities[indexInTable] = (int.Parse(quantities[indexInTable]) + quantityToAdd).ToString();
                        CurrentUser.Cart.cpu_quantity = string.Join(",", quantities);
                        DataAccess.UpdateCart();
                        Close();
                        new FormCart().Show();
                    }
                    break;
                case "GPU":
                    {
                        var ids = CurrentUser.Cart.gpu_id.Split(',').ToList();
                        var indexInTable = ids.IndexOf(index.ToString());
                        var quantities = CurrentUser.Cart.gpu_quantity.Split(',').ToList();
                        quantities[indexInTable] = (int.Parse(quantities[indexInTable]) + quantityToAdd).ToString();
                        CurrentUser.Cart.gpu_quantity = string.Join(",", quantities);
                        DataAccess.UpdateCart();
                        Close();
                        new FormCart().Show();
                    }
                    break;
                case "Motherboard":
                    {
                        var ids = CurrentUser.Cart.mother_board_id.Split(',').ToList();
                        var indexInTable = ids.IndexOf(index.ToString());
                        var quantities = CurrentUser.Cart.mother_board_quantity.Split(',').ToList();
                        quantities[indexInTable] = (int.Parse(quantities[indexInTable]) + quantityToAdd).ToString();
                        CurrentUser.Cart.mother_board_quantity = string.Join(",", quantities);
                        DataAccess.UpdateCart();
                        Close();
                        new FormCart().Show();
                    }
                    break;
                case "RAM":
                    {
                        var ids = CurrentUser.Cart.ram_id.Split(',').ToList();
                        var indexInTable = ids.IndexOf(index.ToString());
                        var quantities = CurrentUser.Cart.ram_quantity.Split(',').ToList();
                        quantities[indexInTable] = (int.Parse(quantities[indexInTable]) + quantityToAdd).ToString();
                        CurrentUser.Cart.ram_quantity = string.Join(",", quantities);
                        DataAccess.UpdateCart();
                        Close();
                        new FormCart().Show();
                    }
                    break;
                case "SSD":
                    {
                        var ids = CurrentUser.Cart.ssd_id.Split(',').ToList();
                        var indexInTable = ids.IndexOf(index.ToString());
                        var quantities = CurrentUser.Cart.ssd_quantity.Split(',').ToList();
                        quantities[indexInTable] = (int.Parse(quantities[indexInTable]) + quantityToAdd).ToString();
                        CurrentUser.Cart.ssd_quantity = string.Join(",", quantities);
                        DataAccess.UpdateCart();
                        Close();
                        new FormCart().Show();
                    }
                    break;
                default:
                    throw new ArgumentException("Невалиден тип!");
            }
        }

        private void buttonRemoveFromCart_Click(object sender, EventArgs e)
        {
            var itemInfo = comboBox1.Text.Split(' ').ToList();
            Program.itemInfo = itemInfo;
            string type = itemInfo[0];
            int index = int.Parse(itemInfo[1][1].ToString());
            int quantityToRemove = Convert.ToInt32(numericUpDown1.Value);
            int currentQuantity;

            switch (type)
            {
                case "HDD":
                    {
                        var ids = CurrentUser.Cart.hdd_id.Split(',').ToList();
                        var indexInTable = ids.IndexOf(index.ToString());
                        var quantities = CurrentUser.Cart.hdd_quantity.Split(',').ToList();
                        currentQuantity = int.Parse(quantities[indexInTable]);
                        if (quantityToRemove == currentQuantity)
                        {
                            RemoveAllItems.HDDs();
                            Close();
                        }
                        else if (quantityToRemove < currentQuantity)
                        {
                            quantities[indexInTable] = (currentQuantity - quantityToRemove).ToString();
                            CurrentUser.Cart.hdd_quantity = string.Join(",", quantities);
                            DataAccess.UpdateCart();
                            Close();
                            new FormCart().Show();
                        }
                        else MessageBox.Show("Не можете да премахнете повече продукти, отколкото имате в количката!");
                    }
                    break;
                case "CPU":
                    {
                        var ids = CurrentUser.Cart.cpu_id.Split(',').ToList();
                        var indexInTable = ids.IndexOf(index.ToString());
                        var quantities = CurrentUser.Cart.cpu_quantity.Split(',').ToList();
                        currentQuantity = int.Parse(quantities[indexInTable]);
                        if (quantityToRemove == currentQuantity)
                        {
                            RemoveAllItems.CPUs();
                            Close();
                        }
                        else if (quantityToRemove < currentQuantity)
                        {
                            quantities[indexInTable] = (currentQuantity - quantityToRemove).ToString();
                            CurrentUser.Cart.cpu_quantity = string.Join(",", quantities);
                            DataAccess.UpdateCart();
                            Close();
                            new FormCart().Show();
                        }
                        else MessageBox.Show("Не можете да премахнете повече продукти, отколкото имате в количката!");
                    }
                    break;
                case "GPU":
                    {
                        var ids = CurrentUser.Cart.gpu_id.Split(',').ToList();
                        var indexInTable = ids.IndexOf(index.ToString());
                        var quantities = CurrentUser.Cart.gpu_quantity.Split(',').ToList();
                        currentQuantity = int.Parse(quantities[indexInTable]);
                        if (quantityToRemove == currentQuantity)
                        {
                            RemoveAllItems.GPUs();
                            Close();
                        }
                        else if (quantityToRemove < currentQuantity)
                        {
                            quantities[indexInTable] = (currentQuantity - quantityToRemove).ToString();
                            CurrentUser.Cart.gpu_quantity = string.Join(",", quantities);
                            DataAccess.UpdateCart();
                            Close();
                            new FormCart().Show();
                        }
                        else MessageBox.Show("Не можете да премахнете повече продукти, отколкото имате в количката!");
                    }
                    break;
                case "Motherboard":
                    {
                        var ids = CurrentUser.Cart.mother_board_id.Split(',').ToList();
                        var indexInTable = ids.IndexOf(index.ToString());
                        var quantities = CurrentUser.Cart.mother_board_quantity.Split(',').ToList();
                        currentQuantity = int.Parse(quantities[indexInTable]);
                        if (quantityToRemove == currentQuantity)
                        {
                            RemoveAllItems.Motherboards();
                            Close();
                        }
                        else if (quantityToRemove < currentQuantity)
                        {
                            quantities[indexInTable] = (currentQuantity - quantityToRemove).ToString();
                            CurrentUser.Cart.mother_board_quantity = string.Join(",", quantities);
                            DataAccess.UpdateCart();
                            Close();
                            new FormCart().Show();
                        }
                        else MessageBox.Show("Не можете да премахнете повече продукти, отколкото имате в количката!");
                    }
                    break;
                case "RAM":
                    {
                        var ids = CurrentUser.Cart.ram_id.Split(',').ToList();
                        var indexInTable = ids.IndexOf(index.ToString());
                        var quantities = CurrentUser.Cart.ram_quantity.Split(',').ToList();
                        currentQuantity = int.Parse(quantities[indexInTable]);
                        if (quantityToRemove == currentQuantity)
                        {
                            RemoveAllItems.RAMs();
                            Close();
                        }
                        else if (quantityToRemove < currentQuantity)
                        {
                            quantities[indexInTable] = (currentQuantity - quantityToRemove).ToString();
                            CurrentUser.Cart.ram_quantity = string.Join(",", quantities);
                            DataAccess.UpdateCart();
                            Close();
                            new FormCart().Show();
                        }
                        else MessageBox.Show("Не можете да премахнете повече продукти, отколкото имате в количката!");
                    }
                    break;
                case "SSD":
                    {
                        var ids = CurrentUser.Cart.ssd_id.Split(',').ToList();
                        var indexInTable = ids.IndexOf(index.ToString());
                        var quantities = CurrentUser.Cart.ssd_quantity.Split(',').ToList();
                        currentQuantity = int.Parse(quantities[indexInTable]);
                        if (quantityToRemove == currentQuantity)
                        {
                            RemoveAllItems.SSDs();
                            Close();
                        }
                        else if (quantityToRemove < currentQuantity)
                        {
                            quantities[indexInTable] = (currentQuantity - quantityToRemove).ToString();
                            CurrentUser.Cart.ssd_quantity = string.Join(",", quantities);
                            DataAccess.UpdateCart();
                            Close();
                            new FormCart().Show();
                        }
                        else MessageBox.Show("Не можете да премахнете повече продукти, отколкото имате в количката!");
                    }
                    break;
                default:
                    throw new ArgumentException("Невалиден тип!");
            }
        }
    }
}
