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
	#endregion
}