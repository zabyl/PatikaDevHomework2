using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            ArrayList chars = new ArrayList();

            string sentence = Console.ReadLine().ToLower();

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence.Contains("a") || sentence.Contains("e") || sentence.Contains("ı") || sentence.Contains("i")
                    || sentence.Contains("o") || sentence.Contains("ö") || sentence.Contains("u") || sentence.Contains("ü"))
                {
                    chars.Add(sentence[i]);
                }
            }


            chars.Sort();

            foreach (var ch in chars)
            {
                Console.Write(ch + " ");
            }


            Console.ReadLine();
        }
    }
}
