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
}