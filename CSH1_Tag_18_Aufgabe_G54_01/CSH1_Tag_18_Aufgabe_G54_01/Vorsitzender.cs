using System;

class Vorsitzender : Personal
{
    public Vorsitzender(int grundgehalt, int bonus, int prozentsatz)
    {
        this.grundgehalt = grundgehalt;
        this.bonus = bonus;
        this.prozentsatz = prozentsatz;
    }
    public override double GetGehalt()
    {
        return (double)(grundgehalt + bonus) * (1 + (prozentsatz / 100.0));
    }

    public override string ToString()
    {
        return "Honorar eines Geschäftsführers: " + GetGehalt().ToString("0.00");
    }

    private int grundgehalt;

    private int bonus;

    private int prozentsatz;

}