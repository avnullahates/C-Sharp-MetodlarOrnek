using System;

namespace OrnekProjeKD11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Github");



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
