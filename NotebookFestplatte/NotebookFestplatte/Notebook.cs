public class Notebook
{
    public string BesitzerNotebook { get; set; }
    public int anzahlFestplatten;
    public List<Festplatte> festplatten;

    public Notebook(string besitzerNotebook)
    {
        BesitzerNotebook = besitzerNotebook;
        festplatten = new List<Festplatte>();
    }
    
    public void AddFestplatte(Festplatte festplatte)
    {
        if (festplatten.Count < 3)
        {
            festplatten.Add(festplatte);
            festplatte.Notebook = this; // Festplatte gehört jetzt diesem (this) Notebook
            anzahlFestplatten++;
        }
        else
        {
            Console.WriteLine("Es sind maximal bloss 3 Festplatten erlaubt!");
        }
    }

    public void RemoveFestplatte(Festplatte festplatte)
    {
        if (festplatten.Remove(festplatte))
        {
            festplatte.Notebook = null; // Festplatte keinem Notebook mehr zugeordnet
            anzahlFestplatten--;        
        }
    }

    public void ShowFestplatten()
    {
        Console.WriteLine($"\r\nDas Notebook von {BesitzerNotebook} hat {festplatten.Count} mit jeweils so viel Speicherplatz:");
        foreach (var festplatte in festplatten)
        {
            Console.WriteLine($"- {festplatte.Modell} mit {festplatte.Speicherplatz} GB");
        }
    }
}