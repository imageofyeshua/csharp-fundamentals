namespace Packt.Shared;

public class Person
{
  #region Properties
  public string? Name { get; set; }
  public DateTimeOffset Born { get; set; }
  public List<Person> Children { get; set; } = new();
  // Allow multiple brothers to be stored for a person.
  public List<Person> Brothers { get; set; } = new();
  // A read-only property to show if a person is sworn to anyone.
  public bool Sworn => Brothers.Count > 0;
  #endregion

  #region Methods
  public void WriteToConsole()
  {
    WriteLine($"{Name} was born on a {Born:dddd}");
  }
  public void WriteChildrenToConsole()
  {
    string term = Children.Count == 1 ? "child" : "children";
    WriteLine($"{Name} has {Children.Count} {term}:");
  }

  // Static method to swear two prothers.
  public static void Pledge(Person p1, Person p2)
  {
    ArgumentNullException.ThrowIfNull(p1);
    ArgumentNullException.ThrowIfNull(p2);

    if (p1.Brothers.Contains(p2) || p2.Brothers.Contains(p1))
    {
      throw new ArgumentException(
        string.Format("{0} is already sworn to {1}.",
        arg0: p1.Name, arg1: p2.Name));
    }
    p1.Brothers.Add(p2);
    p2.Brothers.Add(p1);
  }

  // Instance method to pledge another person.
  public void Pledge(Person brother)
  {
    Pledge(this, brother); // "this" is the current person.
  }

  // Output the brothers of a person if they are sworn.
  public void OutputBrothers()
  {
    if (Sworn)
    {
      string term = Brothers.Count == 1 ? "person" : "people";
      WriteLine($"{Name} is sworn to {Brothers.Count} {term}:");
      foreach (Person brother in Brothers)
      {
        WriteLine($"   {brother.Name}");
      }
    }
    else
    {
      WriteLine($"{Name} is a singleton.");
    }
  }
  /// <summary>
  /// Static method to "multiply" aka procreate and have agape together.
  /// <param name="p1">Person 1</param>
  /// <param name="p2">Person 2</param>
  /// <returns>A Person object that is the child of Brother 1 and Brother 2.</returns>
  /// <exception cref="ArgumentNullException">If p1 or p2 are null.</exception>
  /// <exception cref="ArgumentException">If p1 or p2 are not sworn.</exception>
  public static Person Procreate(Person p1, Person p2)
  {
    ArgumentNullException.ThrowIfNull(p1);
    ArgumentNullException.ThrowIfNull(p2);
    if (!p1.Brothers.Contains(p2) && !p2.Brothers.Contains(p1))
    {
      throw new ArgumentException(string.Format(
        "{0} must be sworn to {1} to procreate agape with them.",
        arg0: p1.Name, arg1: p2.Name
      ));
    }
    Person agape = new()
    {
      Name = $"Apage of {p1.Name} and {p2.Name}",
      Born = DateTimeOffset.Now
    };
    p1.Children.Add(agape);
    p2.Children.Add(agape);
    return agape;
  }

  // Instance method to "multiply".
  public Person ProcreateWith(Person brother)
  {
    return Procreate(this, brother);
  }
  #endregion
}
