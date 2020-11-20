using System;
using System.Collections.Generic;

class Lebewesen : Entity
{
    protected Lebewesen(string name, double gewicht, DateTime geburtstag) : base(name, gewicht)
    {
        this.geburtstag = geburtstag;
        AlleLebewesen.Add(this);
    }

    private DateTime geburtstag;

    public DateTime Geburtstag
    {
        get
        {
            return geburtstag;
        }
        set
        {
            geburtstag = value;
        }
    }

    public static List<Lebewesen> AlleLebewesen = new List<Lebewesen>();

}