using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_18_Aufgabe_G53_00
{
    class Program
    {
        static void Main(string[] args)
        {
            Girokonto g1 = new Girokonto("passwort");

            Console.WriteLine("Abheben mit falschem Pin...");
            g1.Abheben("hjkaskgdaskhgd");

            Console.WriteLine("\n\nAbheben mit korrektem Pin...");
            g1.Abheben("passwort");


            Console.ReadKey();
        }
    }
}
