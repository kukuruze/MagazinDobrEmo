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

        private void FormCPUsShow_Load(object sender, EventArgs e)
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
                    }
                    foreach (var item in ssds)
                    {
                        richTextBoxPrice.Text += $"№{item.Id}: " + item.Price + " лв.\n";
                    }
                    break;
                default:
                    throw new ArgumentException("Invalid type!");
            }
        }
        private void buttonToStoreStart_Click(object sender, EventArgs e)
        {
            richTextBoxInfo.Clear();
            new FormStoreStart().Show();
            Hide();
        }
    }
}
