using System;

namespace OrnekProjeKD11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Github");

            int say1 = Convert.ToInt32(Console.ReadLine());
            int say2 = Convert.ToInt32(Console.ReadLine());
            int toplam = say1 + say2;
            Console.WriteLine("IKI SAYININ TOPLAMI: " +toplam);

            string name = "Bilge Adam";
            EkranaYaz(name);
            Console.ReadLine();
        }

        private static void EkranaYaz(string name)
        {
            Console.WriteLine("Hosgeldiniz " + name);
        }
    }
}
