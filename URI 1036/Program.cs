using System.Globalization;


string[] Value = new string[3];
Value = Console.ReadLine().Split(' ');


double A = double.Parse(Value[0]);
double B = double.Parse(Value[1]);
double C = double.Parse(Value[2]);

if (A <= 0.0 || B <= 0 || C <= 0)
{
    Console.WriteLine("Impossivel calcular");
    Environment.Exit(0);
}

double Delta = Math.Pow(B, 2) - 4 * (A * C);

if (Delta <= 0)
{
    Console.WriteLine("Impossivel calcular");
    Environment.Exit(0);
}

double X1 = (- B + (Math.Sqrt(Delta))) / (2 * A);
double X2 = (- B - (Math.Sqrt(Delta))) / (2 * A);



Console.WriteLine("R1 = " + X1.ToString("F5", CultureInfo.InvariantCulture));
Console.WriteLine("R2 = " + X2.ToString("F5", CultureInfo.InvariantCulture));




