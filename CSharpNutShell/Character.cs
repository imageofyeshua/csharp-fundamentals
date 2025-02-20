namespace LordOfRing;

public class Character
{
  // Constants
  public const string FAMILY = "Fellowship Forever";

  public static int NumberOfCharacters = 0;

  // Properties : private member variables
  private string _name;
  private int _speed = 40;
  private int _strength = 500;

  public int Strength
  {
    get
    {
      WriteLine("Strength get invoked");
      return _strength;
    }
    set
    {
      WriteLine("Strength set invoked");
      _strength = value < 100 ? 100 : value;
      //if (value < 100)
      //{
      //  _strength = 100;
      //}
      //else
      //{
      //  _strength = value;
      //}
    }
  }

  // Constructors
  public Character(string name)
  {
    _name = name;
    NumberOfCharacters++;
    WriteLine($"Created Character {NumberOfCharacters} with name {_name}");
  }

  public Character()
  {
    _name = "No name";
    NumberOfCharacters++;
    WriteLine($"Created Character {NumberOfCharacters} with name {_name}");
  }

  // Functions
  public string GetName()
  {
    return _name;
  }

  public int GetSpeed()
  {
    return _speed;
  }

  public void SetSpeed(int speed)
  {
    if (speed > 90)
    {
      _speed = 90;
    }
    else if (speed < 10)
    {
      _speed = 10;
    }
    else
    {
      _speed = speed;
    }
  }
}
