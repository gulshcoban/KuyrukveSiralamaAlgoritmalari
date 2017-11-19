using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _142802011_142802029_Soru1_
{
    public class CircularQueue : IQueue
    {
        public List<Musteri> Musteriler = new List<Musteri>();
        private object[] Queue;
        public int front = -1;
        public int rear = -1;
        public int size = 0;
        public int count = 0;
        private int BeklemeSuresi = 0;
        private int ToplamBekleme = 0;
        public CircularQueue(int size)
        {
            this.size = size;
            this.Queue = new object[size];
        }
        public void Insert(object o)
        {
            if (count == size)
                throw new Exception("Queue dolu...");
            if (front == -1)
                front = 0;
            if (rear == size - 1)
            {
                rear = 0;
                Queue[rear] = o;
            }
            else
            {
                Queue[++rear] = o;
            }
            count++;
        }
        public object Remove()
        {
            if (IsEmpty())
                throw new Exception("Queue boş...");
            object temp = Queue[front];
            Queue[front] = null;
            if (front == size - 1)
                front = 0;
            else
                front++;
            count--;
            return temp;
        }
        public object Peek()
        {
            return Queue[front];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public int OrtalamaHesapla()
        {
            int Ortalama = 0;

            while (!IsEmpty())
            {
                Musteri n = new Musteri();
                n = (Musteri)Remove();
                BeklemeSuresi += n.IslemSuresi;
                n.BeklemeSuresi = BeklemeSuresi;
                ToplamBekleme += n.BeklemeSuresi;
                Musteriler.Add(n);
            }
            Ortalama = ToplamBekleme / 20;
            return Ortalama;
        }
        public string getElements()
        {
            OrtalamaHesapla();
            string temp = "";
            foreach (Musteri m in Musteriler)
            {

                temp += "Müşteri No: " + m.MusteriNo.ToString() + " İşlem No: " + m.IslemSuresi.ToString() + " Bekleme Süresi: " + m.BeklemeSuresi.ToString() + Environment.NewLine;
            }
            temp += "Ortalama Bekleme Süresi: " + OrtalamaHesapla().ToString();
            return temp;
        }
    }
}
