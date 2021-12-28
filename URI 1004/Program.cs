using System;
using System.Globalization;

namespace URI_1004
{
    class Program
    {
        static void Main (string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int PROD = A * B;

            Console.WriteLine("PROD = " + PROD);
        }
    }
}