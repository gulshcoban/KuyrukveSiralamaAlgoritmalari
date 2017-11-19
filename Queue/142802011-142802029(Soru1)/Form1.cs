using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _142802011_142802029_Soru1_
{
    public partial class frmKuyruk : Form
    {
        CircularQueue cq = new CircularQueue(20);
        PriorityQueue pq = new PriorityQueue(20);
        PriorityQueue2 pq2 = new PriorityQueue2(20);

        public frmKuyruk()
        {
            InitializeComponent();
        }
        public void MusteriEkle()
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                Musteri m = new Musteri();
                m.MusteriNo = i + 1;
                m.IslemSuresi = rnd.Next(60, 600);
                Musteri m1 = new Musteri();
                m1.MusteriNo = m.MusteriNo;
                m1.IslemSuresi = m.IslemSuresi;
                Musteri m2 = new Musteri();
                m2.MusteriNo = m.MusteriNo;
                m2.IslemSuresi = m.IslemSuresi;
                cq.Insert(m);
                pq.Insert(m1);
                pq2.Insert(m2);
            }
        }
        public string KıyasYap(List<Musteri> dairesel, List<Musteri> oncelikli)
        {
            string temp = "";
            foreach (Musteri d in dairesel)
            {
                foreach (Musteri o in oncelikli)
                {
                    if ((d.MusteriNo == o.MusteriNo))
                    {
                        if ((d.BeklemeSuresi > o.BeklemeSuresi))
                            temp += "Öncelikli Kuyrukta daha az beklemiş :" + " Müşteri No: " + o.MusteriNo.ToString() + " İşlem Süresi: " + o.IslemSuresi.ToString() + Environment.NewLine;
                        else if (d.BeklemeSuresi < o.BeklemeSuresi)
                            temp += "Dairesel Kuyrukta daha az beklemiş :" +" Müşteri No: "+ d.MusteriNo.ToString() + " İşlem Süresi: " + d.IslemSuresi.ToString() + Environment.NewLine;
                        else
                            temp += "İkisinde de eşit beklemiş :" + " Müşteri No: " + d.MusteriNo.ToString() + " İşlem Süresi: " + d.IslemSuresi.ToString() + Environment.NewLine;
                    }
                }
            }
            return temp;
        }
        public string KazancHesapla(List<Musteri> kuyruk, int ortalamadeger)
        {
            string temp = "";
            int fark = 0;
            int yuzde = 0;
            foreach (Musteri m in kuyruk)
            {
                if (ortalamadeger > m.BeklemeSuresi)
                {
                    fark = ortalamadeger - m.BeklemeSuresi;
                    yuzde = ((fark * 100) / m.BeklemeSuresi);
                    temp += "KAZANÇ --> Müşteri No: " + m.MusteriNo.ToString() + " Bekleme Süresi: " + m.BeklemeSuresi.ToString()  +" Fark: " + fark.ToString() + " saniye" + " Yüzde: " + yuzde.ToString() + Environment.NewLine;
                }
                else
                {
                    fark = m.BeklemeSuresi - ortalamadeger;
                    yuzde = ((fark * 100) / m.BeklemeSuresi);
                    temp += "KAYIP --> Müşteri No: " + m.MusteriNo.ToString() + " Bekleme Süresi: " + m.BeklemeSuresi.ToString()  + " Fark: " + fark.ToString() + " saniye" + " Yüzde: " + yuzde.ToString() + Environment.NewLine;
                }
            }
            temp += " Ortalama Bekleme Süresi: " + ortalamadeger.ToString();

            return temp;
        }
        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle();
            MessageBox.Show("Müşteriler başarıyla eklenmiştir.");
        }

        private void btnDairesel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cq.getElements());
        }

        private void btnOncelikli_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pq.getElements());
        }

        private void btnOncelikli2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pq2.getElements());
        }

        private void btnDaireselOncelikli_Click(object sender, EventArgs e)
        {
            MessageBox.Show(KıyasYap(cq.Musteriler, pq.Musteriler2));
        }

        private void btnDaireselOncelikli2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(KıyasYap(cq.Musteriler, pq2.Musteriler3));
        }

        private void btnDaireselKazanc_Click(object sender, EventArgs e)
        {
            MessageBox.Show(KazancHesapla(cq.Musteriler, cq.OrtalamaHesapla()));
        }

        private void btnOncelikliKazanc_Click(object sender, EventArgs e)
        {
            MessageBox.Show(KazancHesapla(pq.Musteriler2, pq.OrtalamaHesapla()));
        }

        private void btnOncelikli2Kazanc_Click(object sender, EventArgs e)
        {
            MessageBox.Show(KazancHesapla(pq2.Musteriler3, pq2.OrtalamaHesapla()));
        }
    }
}
