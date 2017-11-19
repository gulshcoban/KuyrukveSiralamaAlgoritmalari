using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Veri_Yapıları_2.Ödev_2.Soru
{
    public class InsertionSort : SortBase
    {
        public override string CalismaZamani(int[] items)
        {
            string temp = "";
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Sort(items);
            stopWatch.Stop();
            TimeSpan t = stopWatch.Elapsed;
            temp = t.TotalMilliseconds.ToString();
            return temp;
        }
        public override void Sort(int[] items)
        {
            int i, j, moved;
            for (i = 1; i < items.Length; i++)
            {
                moved = items[i];
                j = i;
                while (j > 0 && items[j - 1] > moved)
                {
                    items[j] = items[j - 1];
                    j--;
                }
                items[j] = moved;
            }
        }
    }
}
