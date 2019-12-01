using BML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DovizKuruIslemleri islem = new DovizKuruIslemleri();
            IEnumerable<DovizKuruModel> liste = islem.DovizKurlari();
            foreach (DovizKuruModel kur in liste)
            {
                Console.WriteLine($"{kur.CurrencyCode}\n{kur.ForexBuying}\n{kur.ForexSelling}");
            }
            Console.ReadLine();
        }
    }
}
