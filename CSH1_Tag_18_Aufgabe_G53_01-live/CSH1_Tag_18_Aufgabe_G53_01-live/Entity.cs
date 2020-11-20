using System;
using System.Collections.Generic;

class Entity
{
    protected Entity(string name, double gewicht)
    {
        this.name = name;
        this.gewicht = gewicht;
        AlleEntities.Add(this);
    }

    private string name;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    private double gewicht;

    public double Gewicht
    {
        get
        {
            return gewicht;
        }
        set
        {
            gewicht = value;
        }
    }

    public static List<Entity> AlleEntities = new List<Entity>();

}