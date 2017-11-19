using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_Yapıları_2.Ödev_2.Soru
{
    public partial class frmCalismaZamani : Form
    {
        public frmCalismaZamani()
        {
            InitializeComponent();
        }

        public void RandomDataGenerator()
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
                dizi1[i] = rnd.Next();
            for (int i = 0; i < 750; i++)
                dizi2[i] = rnd.Next();  
            for (int i = 0; i < 1500; i++)           
                dizi3[i] = rnd.Next();
            for (int i = 0; i < 7500; i++)
                dizi4[i] = rnd.Next();
            for (int i = 0; i < 15000; i++)
                dizi5[i] = rnd.Next();
            for (int i = 0; i < 75000; i++)
                dizi6[i] = rnd.Next();
            for (int i = 0; i < 150000; i++)
                 dizi7[i] = rnd.Next();
        }
        int[] dizi1 = new int[100];
        int[] dizi2 = new int[750];
        int[] dizi3 = new int[1500];
        int[] dizi4 = new int[7500];
        int[] dizi5 = new int[15000];
        int[] dizi6 = new int[75000];
        int[] dizi7 = new int[150000];
        private void btnRandomVeri_Click(object sender, EventArgs e)
        {
            RandomDataGenerator();
            MessageBox.Show("Veriler üretilmiştir..");
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            BubbleSort bs = new BubbleSort();
            MessageBox.Show("1.Dizi Çalışma Zamanı:" + bs.CalismaZamani(dizi1));
            MessageBox.Show("2.Dizi Çalışma Zamanı:" + bs.CalismaZamani(dizi2));
            MessageBox.Show("3.Dizi Çalışma Zamanı:" + bs.CalismaZamani(dizi3));
            MessageBox.Show("4.Dizi Çalışma Zamanı:" + bs.CalismaZamani(dizi4));
            MessageBox.Show("5.Dizi Çalışma Zamanı:" + bs.CalismaZamani(dizi5));
            MessageBox.Show("6.Dizi Çalışma Zamanı:" + bs.CalismaZamani(dizi6));
            MessageBox.Show("7.Dizi Çalışma Zamanı:" + bs.CalismaZamani(dizi7));
        }
        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            SelectionSort ss = new SelectionSort();
            MessageBox.Show("1.Dizi Çalışma Zamanı:" + ss.CalismaZamani(dizi1));
            MessageBox.Show("2.Dizi Çalışma Zamanı:" + ss.CalismaZamani(dizi2));
            MessageBox.Show("3.Dizi Çalışma Zamanı:" + ss.CalismaZamani(dizi3));
            MessageBox.Show("4.Dizi Çalışma Zamanı:" + ss.CalismaZamani(dizi4));
            MessageBox.Show("5.Dizi Çalışma Zamanı:" + ss.CalismaZamani(dizi5));
            MessageBox.Show("6.Dizi Çalışma Zamanı:" + ss.CalismaZamani(dizi6));
            MessageBox.Show("7.Dizi Çalışma Zamanı:" + ss.CalismaZamani(dizi7));
        }
        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            InsertionSort ins = new InsertionSort();
            MessageBox.Show("1.Dizi Çalışma Zamanı:" + ins.CalismaZamani(dizi1));
            MessageBox.Show("2.Dizi Çalışma Zamanı:" + ins.CalismaZamani(dizi2));
            MessageBox.Show("3.Dizi Çalışma Zamanı:" + ins.CalismaZamani(dizi3));
            MessageBox.Show("4.Dizi Çalışma Zamanı:" + ins.CalismaZamani(dizi4));
            MessageBox.Show("5.Dizi Çalışma Zamanı:" + ins.CalismaZamani(dizi5));
            MessageBox.Show("6.Dizi Çalışma Zamanı:" + ins.CalismaZamani(dizi6));
            MessageBox.Show("7.Dizi Çalışma Zamanı:" + ins.CalismaZamani(dizi7));
        }
        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            QuickSort qs = new QuickSort(); 
            MessageBox.Show("1.Dizi Çalışma Zamanı:" + qs.CalismaZamani(dizi1));
            MessageBox.Show("2.Dizi Çalışma Zamanı:" + qs.CalismaZamani(dizi2));
            MessageBox.Show("3.Dizi Çalışma Zamanı:" + qs.CalismaZamani(dizi3));
            MessageBox.Show("4.Dizi Çalışma Zamanı:" + qs.CalismaZamani(dizi4));
            MessageBox.Show("5.Dizi Çalışma Zamanı:" + qs.CalismaZamani(dizi5));
            MessageBox.Show("6.Dizi Çalışma Zamanı:" + qs.CalismaZamani(dizi6));
            MessageBox.Show("7.Dizi Çalışma Zamanı:" + qs.CalismaZamani(dizi7));
        }
        private void btnHeapSort_Click(object sender, EventArgs e)
        {
            HeapSort hs = new HeapSort();
            MessageBox.Show("1.Dizi Çalışma Zamanı:" + hs.CalismaZamani(dizi1));
            MessageBox.Show("2.Dizi Çalışma Zamanı:" + hs.CalismaZamani(dizi2));
            MessageBox.Show("3.Dizi Çalışma Zamanı:" + hs.CalismaZamani(dizi3));
            MessageBox.Show("4.Dizi Çalışma Zamanı:" + hs.CalismaZamani(dizi4));
            MessageBox.Show("5.Dizi Çalışma Zamanı:" + hs.CalismaZamani(dizi5));
            MessageBox.Show("6.Dizi Çalışma Zamanı:" + hs.CalismaZamani(dizi6));
            MessageBox.Show("7.Dizi Çalışma Zamanı:" + hs.CalismaZamani(dizi7));
        }

    }
}
