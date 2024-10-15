public class Program
{
    static void Main(string[] args)
    {
        // Bücher erzeugen
        Buch buch1 = new Buch("Schuld und Sühne - Fjodor Dostojewski");
        Buch buch2 = new Buch("Der Fremde - Albert Camus");
        Buch buch3 = new Buch("Frankenstein - Mary Shelley");
        Buch buch4 = new Buch("Das Bildnis des Dorian Grey - Oscar Wilde");
        Buch buch5 = new Buch("Die Verwandlung - Franz Kafka");
        Buch buch6 = new Buch("Sturmhöhe - Emily Brontë");
        Buch buch7 = new Buch("Die toten Seeln - Nikolai Gogol");

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
    }
}