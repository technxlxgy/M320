public class Mitarbeiter
{
    public string Name { get; set; }
    public List<Firma> Firmen { get; set; }

    // Konstruktor
    public Mitarbeiter(string name)
    {
        Name = name;
        Firmen = new List<Firma>();
    }

    public void SetFirma(Firma firma)
    {
        if (!Firmen.Contains(firma))
        {
            Firmen.Add(firma);
            firma.SetMitarbeiter(this); // Verkn�pfung auch von der Firmen-Seite aus
        }
    }

    public void GetFirma()
    {
        Console.WriteLine($"\n\r{this.Name} arbeitet f�r:");
        foreach(var firma in Firmen)
        {
            Console.WriteLine($"- {firma.Name}");
        }
    }
}