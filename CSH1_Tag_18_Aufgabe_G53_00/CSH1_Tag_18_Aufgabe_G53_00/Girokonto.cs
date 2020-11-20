using System;

class Girokonto : Bankkonto
{
    public void Abheben(string pin)
    {
        if(pin == this.pin)
            Console.WriteLine("Abheben geglückt!");
        else
            Console.WriteLine("Falscher Pin!");
    }

    public Girokonto(string pin) : base(pin)
    {
        
    }

}