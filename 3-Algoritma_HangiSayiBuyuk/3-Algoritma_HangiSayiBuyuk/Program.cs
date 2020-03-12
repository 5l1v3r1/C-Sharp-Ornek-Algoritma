using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Algoritma_HangiSayiBuyuk
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, sayi3;

            Console.WriteLine("İlk Sayıyı Girin..");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı Girin..");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçüncü Sayıyı Girin..");
            sayi3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Girdiğiniz Sayılar: [" + sayi1 + "," + sayi2 + "," + sayi3 + "]");

            if (sayi1 > sayi2 && sayi1 > sayi2)
            {
                Console.WriteLine("En büyük sayı: " + sayi1);
            }
            else if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                Console.WriteLine("En büyük sayı: " + sayi2);
            }
            else if (sayi3 > sayi1 && sayi3 > sayi2)
            {
                Console.WriteLine("En büyük sayı: " + sayi3);
            }
            Console.ReadLine();
        }
    }
}
