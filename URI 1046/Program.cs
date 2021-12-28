using System;


namespace URI_1046
{

    static class Program
    {
        static void Main(String[] args)
        {


            string[] vetnumber = new string[2];

            vetnumber = Console.ReadLine().Split(' ');


            int hi = int.Parse(vetnumber[0]);
            int hf = int.Parse(vetnumber[1]);

            int hr = hf - hi;

            if (hr < 0)
            {
                hr = 24 + (hf - hi);
            }

            if (hf == hi)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            else
            {
                Console.WriteLine("O JOGO DUROU " + hr + " HORA(S)");
            }
        }
    }
}