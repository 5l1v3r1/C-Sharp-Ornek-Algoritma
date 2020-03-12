using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Algoritma_VizeFinalHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {

            double notV, notF, ort;

            Console.Write("Vize Notunu Giriniz..:");
            notV = Convert.ToDouble(Console.ReadLine());

            Console.Write("Final Notunu Giriniz..:");
            notF = Convert.ToDouble(Console.ReadLine());

            ort = (notV * 40 / 100) + (notF * 60 / 100);

            if (ort > 45)
            {
                Console.WriteLine("Ortalamanız: " + ort + " - Geçti");
            }
            else if (ort < 45)
            {
                Console.WriteLine("Ortalamanız: " + ort + " - Kaldı");
            }

            Console.ReadLine();

        }
    }
}
