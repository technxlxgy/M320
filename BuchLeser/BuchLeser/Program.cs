public class Program
{
    static void Main(string[] args)
    {
        // Bücher erzeugen
        Buch buch1 = new Buch("Schuld und Sühne");
        Buch buch2 = new Buch("Der Fremde");
        Buch buch3 = new Buch("Frankenstein");
        Buch buch4 = new Buch("Das Bildnis des Dorian Grey");
        Buch buch5 = new Buch("Die Verwandlung");
        Buch buch6 = new Buch("Sturmhöhe");
        Buch buch7 = new Buch("Die toten Seeln");

        // Leser erzeugen 
        Leser leser1 = new Leser("Iva");
        Leser leser2 = new Leser("Ina");
        Leser leser3 = new Leser("Isa");
        Leser leser4 = new Leser("Ida");

        // der Leser leiht Bücher aus
        leser1.LeiheBuchAus(buch7);
        leser1.LeiheBuchAus(buch6);
        leser2.LeiheBuchAus(buch5);
        leser2.LeiheBuchAus(buch4);
        leser3.LeiheBuchAus(buch3);
        leser4.LeiheBuchAus(buch2);
        leser4.LeiheBuchAus(buch1);

        // die ausgeliehenen Bücher anzeigen
        leser1.ZeigGeleihteBuecher();
        leser2.ZeigGeleihteBuecher();
        leser3.ZeigGeleihteBuecher();
        leser4.ZeigGeleihteBuecher();

        // damit sich das Terminal nicht direkt wieder schliesst (bruh)
        Console.ReadLine();
    }
}