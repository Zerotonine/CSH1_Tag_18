using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

abstract class Personal
{
    public abstract double GetGehalt();
    public abstract override string ToString();


    /// <summary>
    /// Fügt Angestellte hinzu
    /// <list type="number">
    /// <item>
    /// <description>parameter = Grundgehalt</description>
    /// </item>
    /// <item>
    /// <description>parameter = Bonus</description>
    /// </item>
    /// <item>
    /// <description>parameter = Prozentsatz Aufschlag</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <returns></returns>
    public static Personal AddAngestellten(params int[] list)
    {
        if (list.Length == 1)
        {
            personalListe.Add(new Mitarbeiter(list[0]));
            return personalListe.Last();
        }
        else if (list.Length == 2)
        {
            personalListe.Add(new Vorgesetzter(list[0], list[1]));
            return personalListe.Last();
        }
        else if (list.Length == 3)
        {
            personalListe.Add(new Vorsitzender(list[0], list[1], list[2]));
            return personalListe.Last();
        }
        else
            throw new Exception("Parameterzahl ungültig!");
    }

    public static string GehaelterAusgeben(int umsatz)
    {
        double gewinn = umsatz;
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Umsatz: " + umsatz + "\n");
        sb.AppendLine("Auflistung aller Gehälter:");
        foreach (Personal p in personalListe)
        {
            sb.AppendLine(p.ToString());
            gewinn -= p.GetGehalt();
        }
        sb.AppendLine("\nGewinn: " + gewinn.ToString("0.00"));
        return sb.ToString();
    }

    private static List<Personal> personalListe = new List<Personal>();

    public static List<Personal> PersonalListe
    {
        get
        {
            return personalListe;
        }
    }

}