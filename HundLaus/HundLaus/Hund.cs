public class Hund
{
    public string Name { get; }
    private List<Laus> laeuse;

    public Hund(string name)
    {
        Name = name;
        laeuse = new List<Laus>();
    }

    public void AddLaus(Laus laus)
    {
        laeuse.Add(laus);
        laus.SetWirt(this); // Sets Wirt for the L�use
    }

    public void HundOutput()
    {
        Console.WriteLine($"{Name} hat folgende L�use:");
        foreach(var laus in laeuse)
        {
            laus.LausOutput();
        }
        Console.WriteLine("");
    }
}