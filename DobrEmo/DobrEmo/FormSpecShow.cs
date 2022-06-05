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
    public partial class FormSpecShow : Form
    {
        string hardwareSpec;
        public FormSpecShow()
        {
            InitializeComponent();
        }
        public FormSpecShow(string hardwareType)
        {
            hardwareSpec = hardwareType;
            InitializeComponent();
        }

        private void FormSpecs_Load(object sender, EventArgs e)
        {
            richTextBoxInfo.Text += $"{hardwareSpec}s: \n";
            richTextBoxPrice.Text += $"Цени: \n";
            switch (hardwareSpec)
            {
                case "CPU":
                    
                    List<CPU> cpus = DataAccess.GetCPUs();
                    foreach (var item in cpus)
                    {
                        richTextBoxInfo.Text += item.InfoNoPrice() + "\n";
                        comboBox1.Items.Add(item.InfoNoPrice());
                    }
                    foreach(var item in cpus)
                    {
                        richTextBoxPrice.Text += $"№{item.Id}: " + item.Price + " лв.\n";
                    }
                    break;
                case "GPU":
                    List<GPU> gpus = DataAccess.GetGPUs();
                    foreach (var item in gpus)
                    {
                        richTextBoxInfo.Text += item.InfoNoPrice() + "\n";
                        comboBox1.Items.Add(item.InfoNoPrice());
                    }
                    foreach (var item in gpus)
                    {
                        richTextBoxPrice.Text += $"№{item.Id}: " + item.Price + " лв.\n";
                    }

                    break;
                case "Motherboard":
                    List<MotherBoard> motherboards = DataAccess.GetMotherBoards();
                    foreach (var item in motherboards)
                    {
                        richTextBoxInfo.Text += item.InfoNoPrice() + "\n";
                        comboBox1.Items.Add(item.InfoNoPrice());
                    }
                    foreach (var item in motherboards)
                    {
                        richTextBoxPrice.Text += $"№{item.Id}: " + item.Price + " лв.\n";
                    }
                    break;
                case "HDD":
                    List<HDD> hdds = DataAccess.GetHDDs();
                    foreach (var item in hdds)
                    {
                        richTextBoxInfo.Text += item.InfoNoPrice() + "\n";
                        comboBox1.Items.Add(item.InfoNoPrice());
                    }
                    foreach (var item in hdds)
                    {
                        richTextBoxPrice.Text += $"№{item.Id}: " + item.Price + " лв.\n";
                    }
                    break;
                case "RAM":
                    List<RAM> rams = DataAccess.GetRAMs();
                    foreach (var item in rams)
                    {
                        richTextBoxInfo.Text += item.InfoNoPrice() + "\n";
                        comboBox1.Items.Add(item.InfoNoPrice());
                    }
                    foreach (var item in rams)
                    {
                        richTextBoxPrice.Text += $"№{item.Id}: " + item.Price + " лв.\n";
                    }
                    break;
                case "SSD":
                    List<SSD> ssds = DataAccess.GetSSDs();
                    foreach (var item in ssds)
                    {
                        richTextBoxInfo.Text += item.InfoNoPrice() + "\n";
                        comboBox1.Items.Add(item.InfoNoPrice());
                    }
                    foreach (var item in ssds)
                    {
                        richTextBoxPrice.Text += $"№{item.Id}: " + item.Price + " лв.\n";
                    }
                    break;
                default:
                    throw new ArgumentException("Невалиден тип!");
            }
        }
        private void buttonToStoreStart_Click(object sender, EventArgs e)
        {
            richTextBoxInfo.Clear();
            new FormStoreStart().Show();
            Hide();
        }



        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            /*if (hardwareSpec == "RAM" || hardwareSpec == "SSD")
            {
                MessageBox.Show("Количеството е било изчерпано! Извинете за неудобството!");
                return;
            }*/
            int index = comboBox1.SelectedIndex + 1;
            int quantity = Convert.ToInt32(numericUpDown1.Value);
            Cart cart = CurrentUser.Cart;
            switch (hardwareSpec)
            {
                case "CPU":
                    if(cart.cpu_id == null || cart.cpu_id == "")
                    {
                        cart.cpu_id = index.ToString();
                        cart.cpu_quantity = quantity.ToString();
                    }
                    else
                    {
                        var ids = cart.cpu_id.Split(',').ToList();
                        var quants = cart.cpu_quantity.Split(',').ToList();
                        for (int i = 0; i < ids.Count; i++)
                        {
                            if(ids[i]==index.ToString())
                            {
                                quants[i] = Convert.ToString(int.Parse(quants[i]) + quantity);
                                string newId = string.Join(",", ids);
                                string newQuant = string.Join(",", quants);
                                cart.cpu_id = newId;
                                cart.cpu_quantity = newQuant;
                                CurrentUser.Cart = cart;
                                DataAccess.UpdateCart();
                                MessageBox.Show("Добавено в количката!");
                                return;
                            }
                        }
                        cart.cpu_id += "," + index.ToString();
                        cart.cpu_quantity += "," + quantity.ToString();
                    }
                    break;
                case "GPU":
                    if (cart.gpu_id == null || cart.gpu_id == "")
                    {
                        cart.gpu_id = index.ToString();
                        cart.gpu_quantity = quantity.ToString();
                    }
                    else
                    {
                        var ids = cart.gpu_id.Split(',').ToList();
                        var quants = cart.gpu_quantity.Split(',').ToList();
                        for (int i = 0; i < ids.Count; i++)
                        {
                            if (ids[i] == index.ToString())
                            {
                                quants[i] = Convert.ToString(int.Parse(quants[i]) + quantity);
                                string newId = string.Join(",", ids);
                                string newQuant = string.Join(",", quants);
                                cart.gpu_id = newId;
                                cart.gpu_quantity = newQuant;
                                CurrentUser.Cart = cart;
                                DataAccess.UpdateCart();
                                MessageBox.Show("Добавено в количката!");
                                return;
                            }
                        }
                        cart.gpu_id += "," + index.ToString();
                        cart.gpu_quantity += "," + quantity.ToString();
                    }
                    break;
                case "Motherboard":
                    if (cart.mother_board_id == null || cart.mother_board_id == "")
                    {
                        cart.mother_board_id = index.ToString();
                        cart.mother_board_quantity = quantity.ToString();
                    }
                    else
                    {
                        var ids = cart.mother_board_id.Split(',').ToList();
                        var quants = cart.mother_board_quantity.Split(',').ToList();
                        for (int i = 0; i < ids.Count; i++)
                        {
                            if (ids[i] == index.ToString())
                            {
                                quants[i] = Convert.ToString(int.Parse(quants[i]) + quantity);
                                string newId = string.Join(",", ids);
                                string newQuant = string.Join(",", quants);
                                cart.mother_board_id = newId;
                                cart.mother_board_quantity = newQuant;
                                CurrentUser.Cart = cart;
                                DataAccess.UpdateCart();
                                MessageBox.Show("Добавено в количката!");
                                return;
                            }
                        }
                        cart.mother_board_id += "," + index.ToString();
                        cart.mother_board_quantity += "," + quantity.ToString();
                    }
                    break;
                case "HDD":
                    if (cart.hdd_id == null || cart.hdd_id == "")
                    {
                        cart.hdd_id = index.ToString();
                        cart.hdd_quantity = quantity.ToString();
                    }
                    else
                    {
                        var ids = cart.hdd_id.Split(',').ToList();
                        var quants = cart.hdd_quantity.Split(',').ToList();
                        for (int i = 0; i < ids.Count; i++)
                        {
                            if (ids[i] == index.ToString())
                            {
                                quants[i] = Convert.ToString(int.Parse(quants[i]) + quantity);
                                string newId = string.Join(",", ids);
                                string newQuant = string.Join(",", quants);
                                cart.hdd_id = newId;
                                cart.hdd_quantity = newQuant;
                                CurrentUser.Cart = cart;
                                DataAccess.UpdateCart();
                                MessageBox.Show("Добавено в количката!");
                                return;
                            }
                        }
                        cart.hdd_id += "," + index.ToString();
                        cart.hdd_quantity += "," + quantity.ToString();
                    }
                    break;
                case "RAM":
                    if (cart.ram_id == null || cart.ram_id == "")
                    {
                        cart.ram_id = index.ToString();
                        cart.ram_quantity = quantity.ToString();
                    }
                    else
                    {
                        var ids = cart.ram_id.Split(',').ToList();
                        var quants = cart.ram_quantity.Split(',').ToList();
                        for (int i = 0; i < ids.Count; i++)
                        {
                            if (ids[i] == index.ToString())
                            {
                                quants[i] = Convert.ToString(int.Parse(quants[i]) + quantity);
                                string newId = string.Join(",", ids);
                                string newQuant = string.Join(",", quants);
                                cart.ram_id = newId;
                                cart.ram_quantity = newQuant;
                                CurrentUser.Cart = cart;
                                DataAccess.UpdateCart();
                                MessageBox.Show("Добавено в количката!");
                                return;
                            }
                        }
                        cart.ram_id += "," + index.ToString();
                        cart.ram_quantity += "," + quantity.ToString();
                    }
                    break;
                case "SSD":
                    if (cart.ssd_id == null || cart.ssd_id == "")
                    {
                        cart.ssd_id = index.ToString();
                        cart.ssd_quantity = quantity.ToString();
                    }
                    else
                    {
                        var ids = cart.ssd_id.Split(',').ToList();
                        var quants = cart.ssd_quantity.Split(',').ToList();
                        for (int i = 0; i < ids.Count; i++)
                        {
                            if (ids[i] == index.ToString())
                            {
                                quants[i] = Convert.ToString(int.Parse(quants[i]) + quantity);
                                string newId = string.Join(",", ids);
                                string newQuant = string.Join(",", quants);
                                cart.ssd_id = newId;
                                cart.ssd_quantity = newQuant;
                                CurrentUser.Cart = cart;
                                DataAccess.UpdateCart();
                                MessageBox.Show("Добавено в количката!");
                                return;
                            }
                        }
                        cart.ssd_id += "," + index.ToString();
                        cart.ssd_quantity += "," + quantity.ToString();
                    }
                    break;
                default:
                    throw new ArgumentException("Невалиден тип!");
            }
            CurrentUser.Cart = cart;
            DataAccess.UpdateCart();
            MessageBox.Show("Добавено в количката!");
        }
    }
}
