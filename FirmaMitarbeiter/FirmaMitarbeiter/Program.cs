class Program
{
    static void Main(string[] args)
    {
        // Mitarbeiter erstellen
        Mitarbeiter mitarbeiter1 = new Mitarbeiter("Winter");
        Mitarbeiter mitarbeiter2 = new Mitarbeiter("Ningning");
        Mitarbeiter mitarbeiter3 = new Mitarbeiter("Karina");
        Mitarbeiter mitarbeiter4 = new Mitarbeiter("Giselle");
        Mitarbeiter mitarbeiter5 = new Mitarbeiter("Iva");
        Mitarbeiter mitarbeiter6 = new Mitarbeiter("Vanessa");
        Mitarbeiter mitarbeiter7 = new Mitarbeiter("Sandro");
        Mitarbeiter mitarbeiter8 = new Mitarbeiter("Etnik");
        Mitarbeiter mitarbeiter9 = new Mitarbeiter("Tenzin");
        Mitarbeiter mitarbeiter10 = new Mitarbeiter("Michelle");


        // Firmen erstellen
        Firma firma1 = new Firma("Frontify");
        Firma firma2 = new Firma("Bühler");
        Firma firma3 = new Firma("Brüggli");

        mitarbeiter1.SetFirma(firma1);
        mitarbeiter2.SetFirma(firma1);
        mitarbeiter3.SetFirma(firma1);
        mitarbeiter4.SetFirma(firma1);
        mitarbeiter4.SetFirma(firma2);
        mitarbeiter5.SetFirma(firma2);
        mitarbeiter6.SetFirma(firma2);
        mitarbeiter7.SetFirma(firma2);
        mitarbeiter8.SetFirma(firma2);
        mitarbeiter9.SetFirma(firma2);
        mitarbeiter9.SetFirma(firma3);
        mitarbeiter10.SetFirma(firma3);
        mitarbeiter4.SetFirma(firma3);

        firma1.GetMitarbeiter();
        firma3.GetMitarbeiter();
        mitarbeiter10.GetFirma();
        mitarbeiter5.GetFirma();
        mitarbeiter4.GetFirma();

        Console.ReadLine();
    }
}
