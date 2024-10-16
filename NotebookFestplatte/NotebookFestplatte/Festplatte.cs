public class Festplatte
{
    public string Modell;
    public int Speicherplatz;
    public Notebook Notebook { get; set; }

    public Festplatte(string modell, int speicherplatz)
    {
        Modell = modell;
        Speicherplatz = speicherplatz;
    }
}