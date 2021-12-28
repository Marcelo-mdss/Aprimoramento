using System;

namespace URI_1047
{
    static class Program
    {
        static void Main(String[] args)
        {
            String[] vetnumber = new string[4];

            vetnumber = Console.ReadLine().Split(' ');

            int H_inicial = int.Parse(vetnumber[0]);
            int M_inicial = int.Parse(vetnumber[1]);
            int H_final = int.Parse(vetnumber[2]);
            int M_final = int.Parse(vetnumber[3]);

            int ht, mt;

            if (H_final > H_inicial) 
            { 
                ht = H_final - H_inicial;
                if ()
                {

                }
                

                
            }
            else
            {
                ht = 24 + (H_final - H_inicial);
            }

            Console.WriteLine(ht);

        }
    }
}