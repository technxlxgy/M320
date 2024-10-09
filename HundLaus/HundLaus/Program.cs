class Program
{
    static void Main(string[] args)
    {
        // Create Hund
        Hund hundEins = new Hund("Luna");
        Hund hundZwei = new Hund("Charlie");

        // Create Läuse
        Laus lausEins = new Laus("Laus1", hundEins);
        Laus lausZwei = new Laus("Laus2", hundEins);
        Laus lausDrei = new Laus("Laus3", hundEins);
        Laus lausVier = new Laus("Laus4", hundZwei);
        Laus lausFuenf = new Laus("Laus5", hundZwei);

        // Hund adds Läuse to his list of Läuse
        hundEins.AddLaus(lausEins);
        hundEins.AddLaus(lausZwei);
        hundEins.AddLaus(lausDrei);
        hundZwei.AddLaus(lausVier);
        hundZwei.AddLaus(lausFuenf);

        // Information about Hund and his Läuse -> Output
        hundEins.HundOutput();
        hundZwei.HundOutput();
    }
}