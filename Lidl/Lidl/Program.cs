using Lidl;
public class Program
{ 
    static void Main(string[] args)
    {
        Console.WriteLine("Test");

        Person person1 = new Person() { Vorname = "Manuel", Name = "Müller" };
        Kunde kunde1 = new Kunde() { Vorname = "Fridolin", Name = "Mausemann" };
        Lagerist lagerist1 = new Lagerist() { Vorname = "Hans", Name = "Peter" };

        person1.Esse();
        kunde1.Esse();
        lagerist1.Esse();
        kunde1.KaufeEin();
        lagerist1.LagerEin();
    }
}