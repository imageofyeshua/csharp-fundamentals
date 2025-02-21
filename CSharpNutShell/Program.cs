namespace LordOfRing;

public class Program
{
    public static void Main(string[] args)
    {
        WriteLine("Starting...");

        Weapon wp = Weapon.Axe;

        SayWeapon(wp);

        /*
        double frodoHeight = 1.234567;
        WriteLine($"Frodo's height is {frodoHeight:F2} meters");

        double chanceOfVictory = 0.75;
        WriteLine($"Frodo's height is {chanceOfVictory:P1}");

        Mordor m = Mordor.Instance;
        Mordor m2 = Mordor.Instance;
        m.SayHello();
        m.AddOrc();
        m2.AddOrc();
        m.AddOrc();

        WriteLine(m.NumOrcs);
        WriteLine(m2.NumOrcs);

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

        Nephilim trump = new Nephilim("Trump");
        trump.Introduce();
        trump.SneakAround();
        trump.ChangeName("DDoramp");
        trump.Introduce();

        Monster elon = new Monster("Elon Musk");
        elon.Age = 800;
        elon.Introduce();
        elon.GetAge();

        Character.CountCharacters();

        if (trump is Nephilim)
        {
            WriteLine($"{trump.Name} is Nephilim");
        }
        else if (trump is Android)
        {
            WriteLine($"{trump.Name} is Android");
        }

        Rock myRock = new Rock("Granite", 15);
        WriteLine(myRock);
        */
    }
        private static void SayWeapon(Weapon wp)
        {
            WriteLine($"I am using a {wp}");
        }
}
