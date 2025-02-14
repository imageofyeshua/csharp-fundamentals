using System.Globalization;
using System.Text.RegularExpressions;

Write("Enter your age: ");
string input = ReadLine()!;  // Null-forgiving operator.

Regex ageChecker = new(@"^\d+$");
WriteLine(ageChecker.IsMatch(input) ? "Thank you!" : $"This is not a valid age: {input}");

/*
// Syntax
^ : Start of input
$ : End of input
\d : A single digit 
\D : A single non-digit
\s : Whitespace
\S : Non-whitespace
\w : Word characters 
\W : Non-word characters
[A-Za-z0-9] : Range(s) of characters
\^ : ^(caret) character
[aeiou] : Set of characters
[^aeiou] : Not in a set of characters
. : Any single character
\. " : .(dot) character
+ : One or more
? : One or none
{3} : Exactly three
{3,5} : Three to five
{3,} : At least three
{,3} : Up to three

// Example
\d : A single digit somewhere in the input
a : The character "a" somewhere in the input
Bob : The word "Bob" somewhere in the input
^Bob : The word "Bob" at the start of the input
Bob$ : The word "Bob" at the end of the input
^\d{2}$ : Exactly two digits
^[0-9]{2}$ : Exantly two digits
^[A-Z]{4,}$ : At least four uppercase English letters in the ASCII character set only
^[A-Za-z]{4,}$ : At least four upper or lowercase English letters in the ASCII character set only
^[A-Z]{2}\d{3}$ : Two uppercase English letters in the ASCII character set and three digits
^[A-Za-z\u00c0-\u017e]+$ : At least one uppercase or lowercase English letter
                           in the ASCII character set or Enropean letters in the Unicode character set
^d.g$ : The letter d, then any character, and then the letter g i.e. dig or dog
^d\.g$ : Exactly d.g
*/

// C# 1 to 10: Use escaped double-quote characters \"
// string films = "\"Monsters, Inc.\",\"I, Tonya\",\"Lock, Stock and Two Smoking Barrels\"";

// C# 11 or later: Use """ to start and end a raw string literal
string films = """
"Monsters, Inc.","I, Tonya","Lock, Stock and Two Smoking Barrels"
""";

WriteLine($"Films to split: {films}");

string[] filmsDumb = films.Split(',');

WriteLine("Splitting with string.Split method:");
foreach (string film in filmsDumb)
{
  WriteLine($"  {film}");
}

Regex csv = CommaSeparator;

MatchCollection filmsSmart = csv.Matches(films);

WriteLine("Splitting with regular expression:");
foreach (Match film in filmsSmart)
{
  WriteLine($"  {film.Groups[2].Value}");
}

