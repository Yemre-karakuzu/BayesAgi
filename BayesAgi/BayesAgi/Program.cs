using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayesAgi
{
    class Program
    {
        static void Main(string[] args)
        {
            VeriOkuma veri = new VeriOkuma();
            veri.elemanlarListesi("Proje1-Train.txt");
            veri.elemanlarListesi("Proje1-Test.txt");
        }
    }
}
