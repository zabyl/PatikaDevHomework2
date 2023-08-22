using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanlar = new ArrayList();
            ArrayList sayilar = new ArrayList();

            Console.WriteLine("20 adet sayı giriniz: ");


            for (int i = 0; i < 20; i++)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());

                    if (number <= 0)
                    {
                        Console.WriteLine("pozitif sayı giriniz: ");
                    }
                    else
                    {
                        sayilar.Add(number);
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("lütfen yalnızca sayı giriniz: ");
                }
            }

            Console.WriteLine();

            foreach (int num in sayilar)
            {
                if (isPrime(num))
                {
                    asalSayilar.Add(num);
                }
                else
                {
                    asalOlmayanlar.Add(num);
                }
            }


            Console.WriteLine("Asal sayılar: ");
            asalSayilar.Sort();
            asalSayilar.Reverse();

            int totalAsal = 0;

            foreach (int num in asalSayilar)
            {
                Console.Write(num + " ");
                totalAsal += num;

            }

            Console.WriteLine($"Asal sayıların eleman sayısı {asalSayilar.Count}; ortalaması ise {totalAsal / asalSayilar.Count} ");


            Console.WriteLine();

            Console.WriteLine("Asal olmayanlar: ");
            asalOlmayanlar.Sort();
            asalOlmayanlar.Reverse();


            int totalAsalOlmayan = 0;
            foreach (int num in asalOlmayanlar)
            {
                Console.Write(num + " ");
                totalAsalOlmayan += num;
            }

            Console.WriteLine($"Asal sayıların eleman sayısı {asalOlmayanlar.Count}; ortalaması ise {totalAsalOlmayan / asalOlmayanlar.Count} ");

            Console.ReadLine();
        }

        static bool isPrime(int number)
        {
            if ((number == 0) || (number == 1))
            {
                return false;
            }

            if (number == 2)
            {
                return true;
            }

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }

            }
            return true;
        }
    }
}
