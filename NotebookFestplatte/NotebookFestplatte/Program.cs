class Program
{
    static void Main(string[] args)
    {
        // Besitzer des jeweiligen Notebooks festlegen
        Notebook notebookBesitzer1 = new Notebook("Iva");
        Notebook notebookBestizer2 = new Notebook("Isa");
        Notebook notebookBesitzer3 = new Notebook("Ida");
        Notebook notebookBesitzer4 = new Notebook("Ina");

        // Festplatten erzeugen
        Festplatte festplatte1 = new Festplatte("SSD High Performance", 16);
        Festplatte festplatte2 = new Festplatte("TOP SSD", 32);
        Festplatte festplatte3 = new Festplatte("HDD-Festplatte", 100);
        Festplatte festplatte4 = new Festplatte("WD Blue Interne", 16);
        Festplatte festplatte5 = new Festplatte("Samsung Portable SSD", 32);
        Festplatte festplatte6 = new Festplatte("Lenovo Harddrive", 20);
        Festplatte festplatte7 = new Festplatte("Dell", 50);
        Festplatte festplatte8 = new Festplatte("HDD-Festplatte", 32);
        Festplatte festplatte9 = new Festplatte("Lenovo Harddrive", 100);

        // Festplatten hinzufügen
        notebookBesitzer1.AddFestplatte(festplatte9);
        notebookBesitzer1.AddFestplatte(festplatte8);
        notebookBestizer2.AddFestplatte(festplatte7);
        notebookBestizer2.AddFestplatte(festplatte6);
        notebookBestizer2.AddFestplatte(festplatte5);
        notebookBesitzer3.AddFestplatte(festplatte4);
        notebookBesitzer4.AddFestplatte(festplatte3);
        notebookBesitzer4.AddFestplatte(festplatte2);
        notebookBesitzer4.AddFestplatte(festplatte1);


        notebookBesitzer1.ShowFestplatten();
        notebookBestizer2.ShowFestplatten();
        notebookBesitzer3.ShowFestplatten();
        notebookBesitzer4.ShowFestplatten();
        Console.ReadLine();
    }
}
