using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_18_Aufgabe_G54_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            //! Mitarbeiter
            for(int i = 0; i < 20; i++)
            {
                Personal.AddAngestellten(rnd.Next(1900, 2101));
            }

            //! Vorgesetzte
            for (int i = 0; i < 5; i++)
            {
                Personal.AddAngestellten(rnd.Next(3700, 4301), rnd.Next(450, 551));
            }
            
            //! Vorsitzende
            for (int i = 0; i < 2; i++)
            {
                Personal.AddAngestellten(rnd.Next(7500, 8501), rnd.Next(2500, 3101), rnd.Next(5, 16));
            }
            Console.WriteLine(Personal.GehaelterAusgeben(100000));
            
            Console.ReadKey();
        }
    }
}
