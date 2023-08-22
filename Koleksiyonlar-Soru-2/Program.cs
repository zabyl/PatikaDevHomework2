using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList sayilar = new ArrayList();
            ArrayList biggestThree = new ArrayList();
            ArrayList smallestThree = new ArrayList();

            Console.WriteLine("20 adet sayı giriniz: ");


            for (int i = 0; i < 6; i++)
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


            sayilar.Sort();

            int starter = 0;
            int counter = 3;


            while (counter > 0)
            {
                smallestThree.Add(sayilar[starter]);
                counter--;
                starter++;
            }


            sayilar.Reverse();

            int starter2 = 0;
            int counter2 = 3;
            while (counter2 > 0)
            {
                biggestThree.Add(sayilar[starter2]);
                counter2--;
                starter2++;
            }


            Console.WriteLine("en küçük üç sayı: ");
            int totalMin = 0;
            foreach (int num in smallestThree)
            {
                Console.Write(num + " ");
                totalMin += num;
            }
            Console.WriteLine();
            Console.WriteLine("ortalamaları: " + totalMin / 3);


            Console.WriteLine();

            int totalMax = 0;
            Console.WriteLine("en büyük üç sayı: ");
            foreach (int num in biggestThree)
            {
                Console.Write(num + " ");
                totalMax += num;
            }
            Console.WriteLine();
            Console.WriteLine("ortalamaları: " + totalMax / 3);
            Console.WriteLine();

            Console.WriteLine("sayıların ortalamaları toplamı: " + totalMax + totalMin);


            Console.ReadLine();
        }
    }
}
