using System;
using System.Collections.Generic;

class Tier : Lebewesen
{
    public Tier(string name, double gewicht, DateTime geburtstag, int anzahlBeine) : base(name, gewicht, geburtstag)
    {
        this.anzahlBeine = anzahlBeine;
        AlleTiere.Add(this);
    }

    private int anzahlBeine;

    public int AnzahlBeine
    {
        get
        {
            return anzahlBeine;
        }
        set
        {
            anzahlBeine = value;
        }
    }

    public static List<Tier> AlleTiere = new List<Tier>();

}