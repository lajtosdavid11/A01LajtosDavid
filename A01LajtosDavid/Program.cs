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
                atmeneti = Console.ReadLine().Split(';');
                for (int j = 0; j < oszlop; j++)
                {
                    tomb[i] = Convert.ToInt32(atmeneti[j]);
                }
                i++;
            }
            sr.Close();
        }

        static void kiiras()
        {
            for (int i = 0; i < oszlop; i++)
            {
                Console.WriteLine(tomb[i]);
            }
        }
        static int max = tomb[0];
        static int Maximumertek(int max)
        {
            int maximum = tomb[0];
            for (int i = 0; i < oszlop; i++)
            {
                if (tomb[i] > maximum)
                {
                    maximum = tomb[i];
                }
            }
            Console.WriteLine("A maximum: {0}", Maximumertek(maximum));

            return max;
        }
        static int oszthatoak = 0;
        static int Egyediek(int oszthatoak)
        {
            int megszamol = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 7 == 0 && tomb[i] % 5 == 0)
                {
                    StreamWriter sw = new StreamWriter("egyediek.txt");
                    sw.Write("5-tel és 7-tel oszthatók száma {0}");
                    megszamol++;
                    sw.Close();
                }
                
            }
            Console.WriteLine("5 és 7 oszthatóak száma: {0}", Egyediek(megszamol));

            return oszthatoak;

            
        }
        



        static void Main(string[] args)
        {
            beol();
            kiiras();
            Maximumertek(max);
            Egyediek(oszthatoak);


            Console.ReadKey();


        }
    }
}
