public class Leser
{
    public string Name { get; set; }
    private List<Buch> geleihteBuecher = new List<Buch>();

    public Leser(string name)
    { 
        Name = name;
    }

    // der Leser kann Bücher ausleihen
    public void LeiheBuchAus(Buch buch)
    {
        geleihteBuecher.Add(buch);
        //Console.WriteLine($"Der Leser {Name} hat das Buch {buch.Titel} ausgeliehen.");
    }

    // Ausgeliehene Bücher
    public void ZeigGeleihteBuecher()
    {
        Console.WriteLine($"\r\n{Name} hat folgende Bücher ausgeliehen:");
        foreach (var book in geleihteBuecher)
        {
            Console.WriteLine($"- {book.Titel}\r");
        }
    }
}