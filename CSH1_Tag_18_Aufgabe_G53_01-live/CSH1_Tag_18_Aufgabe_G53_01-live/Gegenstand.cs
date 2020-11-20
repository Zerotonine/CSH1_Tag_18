using System;
using System.Collections.Generic;

class Gegenstand : Entity
{
    public Gegenstand(string name, double gewicht, Mensch besitzer) : base(name, gewicht)
    {
        this.besitzer = besitzer;
        AlleGegenstaende.Add(this);
    }

    public Gegenstand(string name, double gewicht) : base(name, gewicht)
    {
        AlleGegenstaende.Add(this);
    }

    private Mensch besitzer;

    public Mensch Besitzer
    {
        get
        {
            return besitzer;
        }
        set
        {
            besitzer = value;
        }
    }

    public static List<Gegenstand> AlleGegenstaende = new List<Gegenstand>();

}