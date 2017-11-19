using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_2.Ödev_2.Soru
{
    public abstract class SortBase
    {
        public abstract void Sort(int[] items);
        public abstract string CalismaZamani(int[] items);
        public string PrintItems(int[] items)
        {
            string tmp = "";
            for (int i = 0; i < items.Length; i++)
            {
                tmp += "items[" + i + "] = " + items[i] + Environment.NewLine;
            }
            return tmp;
        }
    }
}
