using System.Globalization;
using System;

namespace URI_1043
{
    class Program
    {
        static void Main (string[] args)
        {
            string[] Values = Console.ReadLine().Split(' ');

            double A = double.Parse(Values[0], CultureInfo.InvariantCulture);
            double B = double.Parse(Values[1], CultureInfo.InvariantCulture);
            double C = double.Parse(Values[2], CultureInfo.InvariantCulture);

            double Perimetro;
            double area;


            if (B + C > A && A + B > C && A + C > B)
            {
                Perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + Perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = ((A + B) * C) / 2;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture)); ;
            }
        }
    }
}
