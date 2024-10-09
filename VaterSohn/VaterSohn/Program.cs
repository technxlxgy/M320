public class Program
{
	static void Main(string[] args)
	{
        // Vater ohne Kind
        Vater vaterOhneKind = new Vater("Hans");

        // Kind ohne Vater
        Kind kindOhneVater = new Kind("Max");

        // Vater mit Kind
        Vater vaterMitKind = new Vater("Peter");

        // Kind mit Vater
        Kind kindMitVater = new Kind("Lukas");


        // Assoziationen festlegen
        vaterMitKind.Kind = kindMitVater;
        kindMitVater.Vater = vaterMitKind;

        // Output
        Console.WriteLine($"{vaterOhneKind.Name} hat {(vaterOhneKind.Kind == null ? "kein" : "ein")} Kind.");
        Console.WriteLine($"{kindOhneVater.Name} hat { (kindOhneVater.Vater == null ? "keinen" : "einen") } Vater.");

        Console.WriteLine($"{kindMitVater.Name} ist das Kind von {kindMitVater.Vater?.Name}.");
        Console.WriteLine($"{vaterMitKind.Name} hat ein Kind names {vaterMitKind.Kind?.Name}.");
    }
}
