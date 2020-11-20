using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_18_Aufgabe_G53_01_live
{
    class Program
    {
        static void Main(string[] args)
        {
            //! Menschen
            Mensch hans = new Mensch("Hans", 80, Convert.ToDateTime("01.01.1980") ,"Fachinformatiker");
            Mensch klaus = new Mensch("Klaus", 90, Convert.ToDateTime("01.01.1990"), "Elektriker");

            //! Gegenstände
            Gegenstand stuhl = new Gegenstand("Stuhl", 2.5, hans);
            Gegenstand tisch = new Gegenstand("Tisch", 5.5, klaus);

            //! Tiere
            Tier blackBeauty = new Tier("Black Beauty", 700, Convert.ToDateTime("01.01.2010"), 4);
            Tier whiteBeauty = new Tier("White Beauty", 900, Convert.ToDateTime("01.01.2015"), 4);

            //! Ausgabe Entities
            Console.WriteLine("Liste aller Entitäten:");
            foreach(Entity e in Entity.AlleEntities)
            {
                Console.WriteLine(e.Name + " " + e.Gewicht + "kg");
            }

            //! Ausgabe Gegenstände
            Console.WriteLine("\nListe aller Gegenstände:");
            foreach (Gegenstand g in Gegenstand.AlleGegenstaende)
            {
                Console.WriteLine(g.Name + " " + g.Gewicht + "kg" + ", Besitzer: " + g.Besitzer.Name);
            }

            //! Ausgabe Lebewesen
            Console.WriteLine("\nListe aller Lebewesen:");
            foreach (Lebewesen l in Lebewesen.AlleLebewesen)
            {
                Console.WriteLine(l.Name + " " + l.Gewicht + "kg" + ", Geburtstag: " + l.Geburtstag.ToString("dd.MM.yyyy"));
            }

            //! Ausgabe Tiere
            Console.WriteLine("\nListe aller Tiere:");
            foreach (Tier t in Tier.AlleTiere)
            {
                Console.WriteLine(t.Name + " " + t.Gewicht + "kg" + ", Geburtstag: " + t.Geburtstag.ToString("dd.MM.yyyy") + " <" + t.AnzahlBeine + " Beine>");
            }

            //! Ausgabe Menschen
            Console.WriteLine("\nListe aller Menschen:");
            foreach (Mensch m in Mensch.AlleMenschen)
            {
                Console.WriteLine(m.Name + " " + m.Gewicht + "kg" + ", Geburtstag: " + m.Geburtstag.ToString("dd.MM.yyyy") + " <Beruf: " + m.Beruf + ">");
            }

            Console.ReadKey();
        }
    }
}
