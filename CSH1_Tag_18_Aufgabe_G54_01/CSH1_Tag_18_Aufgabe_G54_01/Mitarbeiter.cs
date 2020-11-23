using System;

class Mitarbeiter : Personal
{
    public Mitarbeiter(int grundgehalt)
    {
        this.grundgehalt = grundgehalt;
    }
    public override double GetGehalt()
    {
        return (double)grundgehalt;
    }

    public override string ToString()
    {
        return "Lohn eines Mitarbeiters: " + GetGehalt();
    }

    private int grundgehalt;


}