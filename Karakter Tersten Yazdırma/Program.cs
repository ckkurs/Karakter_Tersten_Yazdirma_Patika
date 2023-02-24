using System;

namespace Karakter_Tersten_Yazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir metin girin: ");
            string metin = Console.ReadLine();
            string output = "";

            for (int i = metin.Length - 1; i >= 0; i--)
            {
                output = output + metin[i];
            }

            Console.WriteLine("Ters çevrilmiş metin: " + output);
            Console.ReadLine();
        }
    }
}
