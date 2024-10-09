public class Kind
{
    public string Name { get; set; }
    public Vater? Vater { get; set; }

    public Kind(string name)
    {
        Name = name;
    }
}
