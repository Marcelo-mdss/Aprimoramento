using System;
using System.Globalization;

namespace URI_1021
{
    class Program
    {
        static void Main (string[] args)
        {

            float n = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;
            float rest;


            Console.WriteLine("NOTAS:");

            float result = n / 100.00f;
            int Money100 = (int) result;
            Console.WriteLine(Money100 + " nota(s) de R$ 100.00");
            rest = n % 100.00f;

            result = rest / 50.00f;
            int Money50 = (int)result;
            Console.WriteLine(Money50 + " nota(s) de R$ 50.00");
            rest = rest % 50.00f;

            result = rest / 20.00f;
            int Money20 = (int)result;
            Console.WriteLine(Money20 + " nota(s) de R$ 20.00");
            rest = rest % 20.00f;
            
            result = rest / 10.00f;
            int Money10 = (int)result;
            Console.WriteLine(Money10 + " nota(s) de R$ 10.00");
            rest = rest % 10.00f;

            result = rest / 5.00f;
            int Money5 = (int)result;
            Console.WriteLine(Money5 + " nota(s) de R$ 5.00");
            rest = rest % 5.00f;

            result = rest / 2.00f;
            int Money2 = (int)result;
            Console.WriteLine(Money2 + " nota(s) de R$ 2.00");
            rest = rest % 2.00f;

            Console.WriteLine("MOEDAS:");

            result = rest / 1.00f;
            int Coin1 = (int)result;
            Console.WriteLine(Coin1 + " moeda(s) de R$ 1.00");
            rest = rest % 1.00f;

            result = rest / 0.50f;
            int Coin_50 = (int)result;
            Console.WriteLine(Coin_50 + " moeda(s) de R$ 0.50");
            rest = rest % 0.50f;

            result = rest / 0.25f;
            int Coin_25 = (int) result;
            Console.WriteLine(Coin_25 + " moeda(s) de R$ 0.25");
            rest = rest % 0.25f;
            
            result = rest / 0.10f;
            int Coin_10 = (int)result;
            Console.WriteLine(Coin_10 + " moeda(s) de R$ 0.10");
            rest = rest % 0.10f;
           
            result = rest / 0.05f;
            int Coin_05 = (int)result;
            Console.WriteLine(Coin_05 + " moeda(s) de R$ 0.05");
            rest = rest % 0.05f;
            double restN = Math.Round(rest, 2, MidpointRounding.ToEven);
           

            result = (float)((float) restN / 0.01);
            int Coin_01 = (int)result;
            Console.WriteLine(Coin_01 + " moeda(s) de R$ 0.01");
            rest = rest % 0.01f;
            




        }
    }
}