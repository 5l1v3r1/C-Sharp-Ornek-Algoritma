using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Algoritma_Faktöriyel_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {

            double sayi, faktoriyel;

            faktoriyel = 1;

            Console.WriteLine("Lütfen Bir Sayı Giriniz..");
            sayi = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel = faktoriyel * i;
                Console.WriteLine(faktoriyel);
            }

            Console.WriteLine(sayi + " sayısının faktöriyeli: " + faktoriyel);

            Console.ReadLine();

        }
    }
}
