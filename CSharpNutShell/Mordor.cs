class Mordor
{
    private static Mordor instance;

    public int NumOrcs { get; set; } = 0;

    private Mordor()
    {
        WriteLine("Mordor instance created!");
    }

    public static Mordor Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Mordor();
            }
            return instance;
        }
    }

    public void SayHello()
    {
        WriteLine("Hello from the Mordor instance!");
    }

    public void AddOrc()
    {
        NumOrcs++;
    }
}
