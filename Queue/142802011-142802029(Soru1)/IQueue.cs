using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _142802011_142802029_Soru1_
{
    public interface IQueue
    {
        void Insert(object o);
        object Remove();
        object Peek();
        bool IsEmpty();
        int OrtalamaHesapla();
        string getElements();
    }
}
