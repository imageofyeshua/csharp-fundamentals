using System.Buffers;
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

string recombined = string.Join(" => ", citiesArray);
WriteLine(recombined);

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("ko-KR");

string fruit = "Apples";
decimal price = 3090.00M;
DateTime when = DateTime.Today;

WriteLine($"Interpolated: {fruit} cost {price:C} on {when:dddd}.");
WriteLine(string.Format("string.Format: {0} cost {1:C} on {2:dddd}.",
  arg0: fruit, arg1: price, arg2: when));

string strong = "{HG0123456789}";
// .NET 8 or later
SearchValues<char> strongSearchValues = SearchValues.Create(strong);
ReadOnlySpan<char> text = "起初{H7225}，神{H430}創造{H1254}天{H8064}地{H776}";
WriteLine($"strong: {strong}");
WriteLine($"text: {text}");
WriteLine($"text.IndexOfAny(strongSearchValues): {text.IndexOfAny(strongSearchValues)}");

string[] names = ["Daniel", "Jason", "Eunice", "Issac"];
// .NET 9 or later
SearchValues<string> namesSearchValues = SearchValues.Create(
  names, StringComparison.OrdinalIgnoreCase
);
ReadOnlySpan<char> sentence = "Our Father in heaven, Be with Daniel, Jason, Eunice, Issac, forever... Amen.";
WriteLine($"names: {string.Join(' ', names)}");
WriteLine($"sentence: {sentence}");
WriteLine($"sentence.IndexOfAny(namesSearchValues): {sentence.IndexOfAny(namesSearchValues)}");