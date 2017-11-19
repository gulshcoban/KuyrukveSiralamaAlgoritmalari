using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace Veri_Yapıları_2.Ödev_2.Soru
{
    public class BubbleSort : SortBase
    {
       
        public override void Sort(int[] items)
        {
            int tarama;
            bool swapped = false;

            for (tarama = 0; tarama < items.Length; tarama++)
            {
                swapped = false;
                 for (int i = 0; i < (items.Length - tarama - 1); i++)
                {
                    if (items[i] > items[i + 1])
                    {
                        int temp;
                        temp = items[i];
                        items[i] = items[i + 1];
                        items[i + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }
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

    }
}
