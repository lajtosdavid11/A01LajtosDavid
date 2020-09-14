using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace A01LajtosDavid
{
    
    class Program
    {
        static int oszlop = 1000;
        static int[] tomb = new int[oszlop];

        static void beol()
        {
            StreamReader sr = new StreamReader("adatok.dat");
            string[] atmeneti;
            int i = 0;
            while (!sr.EndOfStream)
            {
                atmeneti = Console.ReadLine().Split();
                for (int j = 0; j < oszlop; j++)
                {
                    tomb[j] = Convert.ToInt32(atmeneti[j]);
                }
                i++;
            }
            sr.Close();
        }

        static void Main(string[] args)
        {
            beol();


        }
    }
}
