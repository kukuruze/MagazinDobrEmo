using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobrEmo
{
    public static class RemoveAllItems
    {
        public static void HDDs()
        {
            var itemInfo = Program.itemInfo;
            int index = int.Parse(itemInfo[1][1].ToString());

            var ids = CurrentUser.Cart.hdd_id.Split(',').ToList();
            var indexInTable = ids.IndexOf(index.ToString());
            ids.Remove(index.ToString());

            var quantities = CurrentUser.Cart.hdd_quantity.Split(',').ToList();
            quantities.RemoveAt(indexInTable);

            CurrentUser.Cart.hdd_id = string.Join(",", ids);
            CurrentUser.Cart.hdd_quantity = string.Join(",", quantities);

            DataAccess.UpdateCart();
            Program.itemInfo.Clear();
            new FormCart().Show();
        }
        public static void CPUs()
        {
            var itemInfo = Program.itemInfo;
            int index = int.Parse(itemInfo[1][1].ToString());

            var ids = CurrentUser.Cart.cpu_id.Split(',').ToList();
            var indexInTable = ids.IndexOf(index.ToString());
            ids.Remove(index.ToString());

            var quantities = CurrentUser.Cart.cpu_quantity.Split(',').ToList();
            quantities.RemoveAt(indexInTable);

            CurrentUser.Cart.cpu_id = string.Join(",", ids);
            CurrentUser.Cart.cpu_quantity = string.Join(",", quantities);

            DataAccess.UpdateCart();
            Program.itemInfo.Clear();
            new FormCart().Show();
        }
        public static void GPUs()
        {
            var itemInfo = Program.itemInfo;
            int index = int.Parse(itemInfo[1][1].ToString());

            var ids = CurrentUser.Cart.gpu_id.Split(',').ToList();
            var indexInTable = ids.IndexOf(index.ToString());
            ids.Remove(index.ToString());

            var quantities = CurrentUser.Cart.gpu_quantity.Split(',').ToList();
            quantities.RemoveAt(indexInTable);

            CurrentUser.Cart.gpu_id = string.Join(",", ids);
            CurrentUser.Cart.gpu_quantity = string.Join(",", quantities);

            DataAccess.UpdateCart();
            Program.itemInfo.Clear();
            new FormCart().Show();
        }
        public static void Motherboards()
        {
            var itemInfo = Program.itemInfo;
            int index = int.Parse(itemInfo[1][1].ToString());

            var ids = CurrentUser.Cart.mother_board_id.Split(',').ToList();
            var indexInTable = ids.IndexOf(index.ToString());
            ids.Remove(index.ToString());

            var quantities = CurrentUser.Cart.mother_board_quantity.Split(',').ToList();
            quantities.RemoveAt(indexInTable);

            CurrentUser.Cart.mother_board_id = string.Join(",", ids);
            CurrentUser.Cart.mother_board_quantity = string.Join(",", quantities);

            DataAccess.UpdateCart();
            Program.itemInfo.Clear();
            new FormCart().Show();
        }
        public static void RAMs()
        {
            var itemInfo = Program.itemInfo;
            int index = int.Parse(itemInfo[1][1].ToString());

            var ids = CurrentUser.Cart.ram_id.Split(',').ToList();
            var indexInTable = ids.IndexOf(index.ToString());
            ids.Remove(index.ToString());

            var quantities = CurrentUser.Cart.ram_quantity.Split(',').ToList();
            quantities.RemoveAt(indexInTable);

            CurrentUser.Cart.ram_id = string.Join(",", ids);
            CurrentUser.Cart.ram_quantity = string.Join(",", quantities);

            DataAccess.UpdateCart();
            Program.itemInfo.Clear();
            new FormCart().Show();
        }
        public static void SSDs()
        {
            var itemInfo = Program.itemInfo;
            int index = int.Parse(itemInfo[1][1].ToString());

            var ids = CurrentUser.Cart.ssd_id.Split(',').ToList();
            var indexInTable = ids.IndexOf(index.ToString());
            ids.Remove(index.ToString());

            var quantities = CurrentUser.Cart.ssd_quantity.Split(',').ToList();
            quantities.RemoveAt(indexInTable);

            CurrentUser.Cart.ssd_id = string.Join(",", ids);
            CurrentUser.Cart.ssd_quantity = string.Join(",", quantities);

            DataAccess.UpdateCart();
            Program.itemInfo.Clear();
            new FormCart().Show();
        }
    }
}
