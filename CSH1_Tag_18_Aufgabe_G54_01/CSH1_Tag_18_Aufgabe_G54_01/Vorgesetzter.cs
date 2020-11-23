using System;

class Vorgesetzter : Personal
{
    public Vorgesetzter(int grundgehalt, int bonus)
    {
        this.grundgehalt = grundgehalt;
        this.bonus = bonus;
    }
    public override double GetGehalt()
    {
        return (double)(grundgehalt + bonus);
    }

    public override string ToString()
    {
        return "Gehalt eines Vorgesetzten: " + GetGehalt();
    }


    private int grundgehalt;

    private int bonus;

}