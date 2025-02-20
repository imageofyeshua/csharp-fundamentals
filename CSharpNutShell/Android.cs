class Android
{
  public static int Count = 0;

  public string Name { get; private set; }
  public string Race { get; private set; }

  public Android(string name, string race)
  {
    Name = name;
    Race = race;
    Count++;
  }

  public void Introduce()
  {
    WriteLine($"I am {Name}, a {Race}.");
  }

  public static void CountCharacters()
  {
    WriteLine($"There are {Count} characters.");
  }
}
