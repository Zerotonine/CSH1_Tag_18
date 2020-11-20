using System;
using System.Text;

class Song
{
    public Song(string titel, int dauerSekunden, string interpret)
    {
        this.titel = titel;
        this.dauerSekunden = dauerSekunden;
        this.interpret = interpret;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Interpret:\t" + this.interpret);
        sb.AppendLine("Titel:\t\t" + this.titel);
        sb.AppendLine($"Dauer:\t\t{this.dauerSekunden/60:D2}:{this.dauerSekunden%60:D2}");

        return sb.ToString();
    }

    private string titel;

    public string Titel
    {
        get
        {
            return titel;
        }
        set
        {
            titel = value;
        }
    }

    private int dauerSekunden;

    public int DauerSekunden
    {
        get
        {
            return dauerSekunden;
        }
        set
        {
            dauerSekunden = value;
        }
    }

    private string interpret;

    public string Interpret
    {
        get
        {
            return interpret;
        }
        set
        {
            interpret = value;
        }
    }

}