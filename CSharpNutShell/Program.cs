namespace LordOfRing;

public class Program
{
  public static void Main(string[] args)
  {
    Character frodo = new Character("Frodo");
    Character legolas = new Character("Legolas");
    Character nobody = new Character();

    WriteLine($"Name is {frodo.GetName()} with speed: {frodo.GetSpeed()}");
    WriteLine($"Name is {nobody.GetName()}");

    legolas.SetSpeed(100);
    WriteLine($"Name is {legolas.GetName()} with speed: {legolas.GetSpeed()}");

    WriteLine();
    WriteLine($"Name is {frodo.GetName()} with speed: {frodo.Strength}");
    WriteLine($"Name is {legolas.GetName()} with speed: {legolas.Strength}");

    legolas.Strength = 40;
    WriteLine($"Name is {legolas.GetName()} with speed: {legolas.Strength}");

    WriteLine($"We have created {Character.NumberOfCharacters} characters.");

    Utils.SayStuff();
    Utils.SayStuff();
    Utils.SayStuff();
    Utils.SayStuff();
    Utils.SayStuff();
  }
}
