public class Buch
{
    public string Titel { get; set; }

    public Buch(string titel)
    {  
        Titel = titel;
    }

    public override string ToString()
    {
        return Titel;
    }
}