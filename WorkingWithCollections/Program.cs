using System.Collections.Frozen; // To use FrozenDictionary<T, T>
using System.Collections.Immutable; // To use ImmutableDictionary<T, T>
// Define an alias for a dictionary with string key and string value.
using StringDictionary = System.Collections.Generic.Dictionary<string, string>;

List<string> cities = new();
cities.Add("Seoul");
cities.Add("Tokyo");
cities.Add("Beijing");
cities.Add("New York");
cities.Add("Seattle");

/* Alternative syntaxes
List<string> cities = new() { "London", "Paris", "Milan" };
List<string> cities = new();
cities.AddRange(new[] { "London", "Paris", "Milan" });
*/

OutputCollection("Initial list", cities);
WriteLine($"The first city is {cities[0]}.");
WriteLine($"The last city is {cities[cities.Count - 1]}.");
WriteLine(
    $"Are all cities longer than four characters? {cities.TrueForAll(city => city.Length > 4)}."
);
WriteLine(
    $"Do all cities contain the character 'e'? {cities.TrueForAll(city => city.Contains('e'))}."
);
cities.Insert(0, "Sydney");
OutputCollection("After inserting Sydney at index 0", cities);
cities.RemoveAt(1);
cities.Remove("Beijing");
OutputCollection("After removing two cities", cities);

// Declare a dictionary without the alias.
// Dictionary<string, string> keywords = new();
// Use the alias to declare the dictionary.
StringDictionary keywords = new();

// Add using named parameters.
keywords.Add(key: "int", value: "32-bit integer data type");

// Add using positional parameters.
keywords.Add("long", "64-bit integer data type");
keywords.Add("float", "Single precision floating point number");

/* Alternative syntax; compiler converts this to calls to Add method.
Dictionary<string, string> keywords = new()
{
  { "int", "32-bit integer data type" },
  { "long", "64-bit integer data type" },
  { "float", "Single precision floating point number" },
}; */
/* Alternative syntax; compiler converts this to calls to Add method.
Dictionary<string, string> keywords = new()
{
  ["int"] = "32-bit integer data type",
  ["long"] = "64-bit integer data type",
  ["float"] = "Single precision floating point number",
}; */

OutputCollection("Dictionary keys", keywords.Keys);
OutputCollection("Dictionary values", keywords.Values);
WriteLine("Keywords and their definitions:");
foreach (KeyValuePair<string, string> item in keywords)
{
    WriteLine($"   {item.Key}: {item.Value}");
}

// Look up a value using a key.
string key = "long";
WriteLine($"The definition of {key} is {keywords[key]}");

// Sets example
HashSet<string> names = new();

foreach (string name in new[] { "Adam", "Barry", "Charlie", "Barry" })
{
    bool added = names.Add(name);
    WriteLine($"{name} was added: {added}");
}
WriteLine($"names set: {string.Join(',', names)}");

// Queues example

Queue<string> coffee = new();
coffee.Enqueue("Damir"); // Front of the queue.
coffee.Enqueue("Andrea");
coffee.Enqueue("Ronald");
coffee.Enqueue("Amin");
coffee.Enqueue("Irina"); // Front of the queue.

OutputCollection("Initial queue from front to back", coffee);

// Server handles next person in queue.
string served = coffee.Dequeue();
WriteLine($"Served: {served}.");

// Server handles next person in queue.
served = coffee.Dequeue();
WriteLine($"Served: {served}.");
OutputCollection("Initial queue from front to back", coffee);
WriteLine($"{coffee.Peek()} is next in line.");
OutputCollection("Initial queue from front to back", coffee);

// Priority queue example
PriorityQueue<string, int> digitalId = new();

// Add some people.
// 1 = High priority people in their greed for money and this world.
// 2 = Medium priority e.g. lay-men
// 3 = Low priority e.g. awaken people resist Digital Id
digitalId.Enqueue("Pamela", 1);
digitalId.Enqueue("Rebecca", 2);
digitalId.Enqueue("Juliet", 3);
digitalId.Enqueue("Ian", 1);

OutputPQ("Current queue for digitalId", digitalId.UnorderedItems);
WriteLine($"{digitalId.Dequeue()} has been digital ided");
WriteLine($"{digitalId.Dequeue()} has been digital ided");
OutputPQ("Current queue for digitalId", digitalId.UnorderedItems);
WriteLine($"{digitalId.Dequeue()} has been digital ided");
WriteLine("Adding Mark to queue with priority 2.");
digitalId.Enqueue("Mark", 2);
WriteLine($"{digitalId.Peek()} will be next to be digital ided");
OutputPQ("Current queue for digitalId", digitalId.UnorderedItems);

// UseDictionary(keywords);
// UseDictionary(keywords.AsReadOnly());
UseDictionary(keywords.ToImmutableDictionary());

ImmutableDictionary<string, string> immutableKeywords = keywords.ToImmutableDictionary();

// Call the Add method with a return value.
ImmutableDictionary<string, string> newDictionary = immutableKeywords.Add(
    key: Guid.NewGuid().ToString(),
    value: Guid.NewGuid().ToString()
);
OutputCollection("Immutable keywords dictionary", immutableKeywords);
OutputCollection("New keywords dictionary", newDictionary);

// Creating a frozen collection has an overhead to perform complex optimizations.
FrozenDictionary<string, string> frozenKeywords = keywords.ToFrozenDictionary();

OutputCollection("Frozen keywords dictionary", frozenKeywords);

// Lookups are faster in a frozen dictionary.
WriteLine($"Define long: {frozenKeywords["long"]}");

// C# 12 style initialization
int[] numbersArray12 = [1, 3, 5];
List<int> numbersList12 = [1, 3, 5];
Span<int> numbersSpan = [1, 3, 5];

// Spreading elements

int[] row0 = [1, 2, 3];
int[] row1 = [4, 5];
int[] row2 = [6, 7, 8, 9];

int[] combinedRows = [.. row0, .. row1, .. row2];
WriteLine("Spreading elements with dot operator");
foreach (int number in combinedRows)
{
    Write($"{number}, ");
}

// Load ten thousand fruits into the list.
List<string> fruits = new();
fruits.EnsureCapacity(10_000);

// Passing collections to methods and their speed
void IProcessCollection<T>(IEnumerable<T> collection)
{
    // Process the items in the collection
    // Iteration allocates an object on the heap in the memory
}
void LProcessCollection<T>(List<T> collection)
{
    // Process the items in the collection
    // List<T>.Enumerator GetEnumerator() method
    // Returns a struct as a reference type >> 2 ~ 3 times faster
}
IProcessCollection(names);
LProcessCollection(names.ToList());
