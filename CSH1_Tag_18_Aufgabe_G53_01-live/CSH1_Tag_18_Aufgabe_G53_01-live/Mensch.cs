using System;
using System.Collections.Generic;

class Mensch : Lebewesen
{
    public Mensch(string name, double gewicht, DateTime geburtstag, string beruf) : base(name, gewicht, geburtstag)
    {
        this.beruf = beruf;
        AlleMenschen.Add(this);
    }

    private string beruf;

    public string Beruf
    {
        get
        {
            return beruf;
        }
        set
        {
            beruf = value;
        }
    }

    public static List<Mensch> AlleMenschen = new List<Mensch>();

}