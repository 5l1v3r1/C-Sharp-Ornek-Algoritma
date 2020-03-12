using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Pozitif_Negatig_Eşit_Sayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Bir Sayı Giriniz..");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi < 0)
            {
                Console.WriteLine("Sayı Netatif");
            }
            else if(sayi > 0)
            {
                Console.WriteLine("Sayı Pozitif");
            }
            else if (sayi == 0)
            {
                Console.WriteLine("Sayi eşit");
            }
            else
            {
                Console.WriteLine("İşlem başarısız.");
            }

            Console.ReadLine();
        }
    }
}
