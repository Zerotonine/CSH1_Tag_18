using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_18_Aufgabe_G54_04
{
    class Program
    {
        static List<Lebewesen> wesen;
        static void Main(string[] args)
        {
            wesen = new List<Lebewesen>()
            {
                new Lebewesen(),
                new Säugetier(),
                new Hund(),
                new Dackel()
            };

            Console.WriteLine(Ausgabe());
            Console.ReadKey();
        }

        static string Ausgabe()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Lebewesen l in wesen)
            {
                if (l is Dackel)
                    sb.AppendLine("Dackel: " + l.AussageBeine());
                else if (l is Hund)
                    sb.AppendLine("Hund: " + l.AussageBeine());
                else if (l is Säugetier)
                    sb.AppendLine("Säugetier: " + l.AussageBeine());
                else if (l is Lebewesen)
                    sb.AppendLine("Lebewesen: " + l.AussageBeine());
            }

            return sb.ToString();
        }
    }
}
