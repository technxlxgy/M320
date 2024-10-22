public class Firma
{
    public string Name { get; set; }
    public List<Mitarbeiter> MitarbeiterListe { get; set;}
    
    public Firma(string name)
    {
        Name = name;
        MitarbeiterListe = new List<Mitarbeiter>();
    }
    
    public void SetMitarbeiter(Mitarbeiter mitarbeiter)
    {
        if(!MitarbeiterListe.Contains(mitarbeiter))
        {
            MitarbeiterListe.Add(mitarbeiter);
            mitarbeiter.SetFirma(this);
        }
    }

    public void GetMitarbeiter()
    {
        Console.WriteLine($"\n\rIn der Firma {this.Name} arbeiten die Mitarbeiter:");
        foreach(var mitarbeiter in MitarbeiterListe)
        {
            Console.WriteLine($"- {mitarbeiter.Name}");
        }
    }
}