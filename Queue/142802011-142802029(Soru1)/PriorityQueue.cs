using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _142802011_142802029_Soru1_
{
    public class PriorityQueue : IQueue
    {
        public List<Musteri> Musteriler2 = new List<Musteri>();
        private object[] Queue;
        private int front = -1;
        private int size = 0;
        private int count = 0;
        private int BeklemeSuresi = 0;
        private int ToplamBekleme = 0;
        public PriorityQueue(int size)
        {
            this.size = size;
            Queue = new object[size];
        }
        public void Insert(object o)
        {
            if (count == size)
                throw new Exception("Queue is full");
            if (IsEmpty())
            {
                front++;
                Queue[front] = o;
            }
            else
            {
                int i;
                Musteri m = (Musteri)o;
                for (i = count - 1; i >= 0; i--)
                {
                    if (m.IslemSuresi > ((Musteri)Queue[i]).IslemSuresi)
                    {
                        Queue[i + 1] = Queue[i];
                    }
                    else
                        break;
                }


                Queue[i + 1] = o;
                front++;
            }
            count++;
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public object Peek()
        {
            return Queue[front];
        }

        public object Remove()
        {
            if (this.IsEmpty())
            {
                throw new Exception("Queue is empty...");
            }
            object temp = Queue[front];
            Queue[front] = null;
            front--;
            count--;
            return temp;
        }

        public int OrtalamaHesapla()
        {

            int Ortalama = 0;
            while (!IsEmpty())
            {
                Musteri m = new Musteri();
                m = (Musteri)Remove();
                BeklemeSuresi += m.IslemSuresi;
                m.BeklemeSuresi = BeklemeSuresi;
                ToplamBekleme += m.BeklemeSuresi;
                Musteriler2.Add(m);

            }
            Ortalama = ToplamBekleme / 20;
            return Ortalama;
        }
        public string getElements()
        {
            OrtalamaHesapla();
            string temp = "";
            foreach (Musteri m in Musteriler2)
            {
                temp += "Müşteri No: " + m.MusteriNo.ToString() + " İşlem No: " + m.IslemSuresi.ToString() + " Bekleme Süresi: " + m.BeklemeSuresi.ToString() + Environment.NewLine;
            }
            temp += "Ortalama Bekleme Süresi: " + OrtalamaHesapla().ToString();
            return temp;
        }
    }
}
