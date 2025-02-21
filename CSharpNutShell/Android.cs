class Android
{
    public static int Count = 0;

    public string Name { get; protected set; }
    public string Race { get; private set; }
    public int NumFeet { get; set; }

    private int _numEyes;

    public Android(string name, string race)
    {
        Name = name;
        Race = race;
        Count++;
    }

    public virtual void Introduce()
    {
        WriteLine($"I am {Name}, a {Race} with {NumFeet} feet and {_numEyes} eyes.");
    }

    public static void CountCharacters()
    {
        WriteLine($"There are {Count} characters.");
    }
}
