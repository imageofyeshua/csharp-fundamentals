using System.Drawing;
using System.Xml;
using Variables;

object height = 1.88; // storing a double in an object
object name = "Amen"; // storing a string in an object

Console.WriteLine($"{name} is {height} meters tall.");
// int length1 = name.Length; // compile error
int length2 = ((string)name).Length;
Console.WriteLine($"{name} has {length2} characters.");

dynamic something;
// storing an array of int values in a dynamic object
// an array of any type has a Length property
something = new[] { 3, 5, 7 };
// something = 12;
// something = "Daniel";
Console.WriteLine($"The length of something is {something.Length}");
Console.WriteLine($"something is a {something.GetType()}");

int population = 67_000_000;
double weight = 1.88;
decimal price = 4.99M;
string fruit = "Apples";
char letter = 'Z';
bool happy = true;

var xml1 = new XmlDocument(); // works with C# 3 and later
XmlDocument xml2 = new XmlDocument(); // works with all C# versions
XmlDocument xml3 = new();

var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");

short age; // 2 bytes System.Int16
long population2; // 8 bytes System.Int64
DateTime birthdate; // 8 bytes System.DateTime
Point location; // 8 bytes System.Drawing.Point
Person daniel;

age = 45;
population2 = 45_000_000;
birthdate = new(1976, 11, 24);
location = new(10, 20);
daniel = new("Daniel", "Park", 48);

Person kim = new();
kim.BirthDate = new(1976, 12, 26);

List<Person> people = new()
{
  new() { FirstName = "Alice" },
  new() { FirstName = "Bob" },
  new() { FirstName = "Charlie"}
};

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string) ?? "<NULL>"}");

int number = 14;
Console.WriteLine($"number set to: {number}");
number = default;
Console.WriteLine($"number reset to: default {number}");