using System.Globalization; // To use CultureInfo.
OutputEncoding = System.Text.Encoding.UTF8; // Enable Euro symbol.

string city = "Gimcheon";
WriteLine($"{city} is {city.Length} characters long.");
WriteLine($"First char is {city[0]} and fourth is {city[3]}.");

string cities = "Seoul,Tokyo,Sydney,New York,Busan";
string[] citiesArray = cities.Split(',');
WriteLine($"There are {citiesArray.Length} items in the array.");
foreach (string item in citiesArray)
{
  WriteLine($"   {item}");
}

string fullName = "Daniel Park";
int indexOfTheSpace = fullName.IndexOf(' ');
string firstName = fullName.Substring(
  startIndex: 0, length: indexOfTheSpace);
string lastName = fullName.Substring(
  startIndex: indexOfTheSpace + 1);
WriteLine($"Original: {fullName}");
WriteLine($"Swapped: {lastName}, {firstName}");

string company = "BackToTheBible";
WriteLine($"Text: {company}");
WriteLine("Starts with B: {0}, contains T: {1}",
  arg0: company.StartsWith('B'),
  arg1: company.Contains('P'));

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
string text1 = "Mark";
string text2 = "MARK";
WriteLine($"text1: {text1}, text2: {text2}");
WriteLine("Compare (ignoreCase): {0}.",
  string.Compare(text1, text2, ignoreCase: true));
WriteLine("Compare (InvariantCultureIgnoreCase): {0}.",
  string.Compare(text1, text2, StringComparison.InvariantCultureIgnoreCase));

// German string comparisons
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
text1 = "Strasse";
text2 = "Straße";
WriteLine($"text1: {text1}, text2: {text2}");
WriteLine("Compare: {0}.",
  string.Compare(text1, text2,
  CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace));
WriteLine("Compare (IgnoreCase, IgnoreNonSpace): {0}.",
  string.Compare(text1, text2, CultureInfo.CurrentCulture,
  CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreCase));
WriteLine("Compare (InvariantCultureIgnoreCase): {0}.",
  string.Compare(text1, text2,
  StringComparison.InvariantCultureIgnoreCase));