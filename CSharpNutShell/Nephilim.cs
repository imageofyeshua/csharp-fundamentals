class Nephilim : Android
{
    public Nephilim(string name)
        : base(name, "Nephilim") { }

    public void SneakAround()
    {
        WriteLine($"{Name} the {Race} is sneaking around. Be careful!!");
    }

    public void ChangeName(string name)
    {
        Name = name;
    }
}
