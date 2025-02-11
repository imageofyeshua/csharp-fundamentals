namespace Packt.Shared;

public class Person : object
{
	#region Fields: Data or state for this person.
	public string? Name; // ? means it can be null.
	public DateTimeOffset Born;
	public WondersOfTheAncientWorld FavoriteAncientWonder;
	public WondersOfTheAncientWorld BucketList;
	public List<Person> Children = new();
	// Constant fields: Values that are fixed at compilation.
	public const string Race = "Yehuda";
	// Read-only fields: Values that can be se at runtime.
	public readonly string HomeSpace = "Earth";
	public readonly DateTime Instantiated;
	#endregion
	#region Constructors: Called when using new to instantiate a type.
	public Person()
	{
		// Constructors can set default values for fields
		// including any read-only fields like Instantiated.
		Name = "Unknown";
		Instantiated = DateTime.Now;
	}
	public Person(string initialName, string homeSpace)
	{
		Name = initialName;
		HomeSpace = homeSpace;
		Instantiated = DateTime.Now;
	}
	#endregion
	#region Methods: Actions the type can perform.
	public void WriteToConsole()
	{
		WriteLine($"{Name} was born on a {Born:dddd}");
	}
	public string GetOrigin()
	{
		return $"{Name} was born on {HomeSpace}";
	}
	public string SayHello()
	{
		return $"{Name} says 'Hello!'";
	}
	public string SayHelloTo(string name)
	{
		return $"{Name} says 'Hello, {name}!";
	}
	public string OptionalParameters(int count, string command = "Run!",
		double number = 0.0, bool active = true)
	{
		return string.Format(
			format: "command is {0}, number is {1}, active is {2}",
			arg0: command,
			arg1: number,
			arg2: active
		);
	}
	public void PassingParameters(int w, in int x, ref int y, out int z)
	{
		// out parameters cannot have a default and they must be initialized inside the method.
		z = 100;
		// Increment each parameter except the read-only x.
		w++;
		// x++; // Gives a compiler error!
		y++;
		z++;
		WriteLine($"In the method: w={w}, x={x}, y={y}, z={z}");
	}
	public void ParamsParameters(
		string text, params int[] numbers)
	{
		int total = 0;
		foreach (int number in numbers)
		{
			total += number;
		}
		WriteLine($"{text}: {total}");
	}
	#endregion
}