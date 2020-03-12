using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Algoritma_KomisyonHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {

            double malFiyat, komisyon, kazanc;

            malFiyat = 0;
            komisyon = 0;
            kazanc = 0;

            for (int sayac = 0; sayac < 5; sayac++)
            {
                Console.Write("Mal Fiyatı Giriniz: ");
                malFiyat = Convert.ToDouble(Console.ReadLine());

                if (malFiyat < 50)
                {
                    //komisyon = (malFiyat/100) * 3;
                    komisyon = malFiyat * 0.03;
                }
                else
                {
                    //komisyon = (malFiyat / 100) * 2;
                    komisyon = malFiyat * 0.02;
                }

                Console.WriteLine("Komisyon: " + komisyon);

                kazanc = komisyon + kazanc;
            }

            Console.WriteLine("Toplam Kazanç: " + kazanc);

            Console.ReadLine();

        }
    }
}
