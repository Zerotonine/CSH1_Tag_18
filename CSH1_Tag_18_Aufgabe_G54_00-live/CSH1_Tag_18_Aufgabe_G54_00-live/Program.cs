using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_18_Aufgabe_G54_00_live
{
    class Program
    {
        static void Main(string[] args)
        {
            Song s1 = new Song("Checkmate", 270, "Lamb of God");

            Console.WriteLine(s1.ToString());

            Console.ReadKey();
        }
    }
}
