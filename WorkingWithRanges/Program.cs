string name = "Daniel Park";

// Getting the lengths of the first and last names.
int lengthOfFirst = name.IndexOf(' ');
int lengthOfLast = name.Length - lengthOfFirst - 1;

// Using Substring.
string firstName = name.Substring(
  startIndex: 0,
  length: lengthOfFirst
);

string lastName = name.Substring(
  startIndex: name.Length - lengthOfLast,
  length: lengthOfLast
);

WriteLine($"First: {firstName}, Last: {lastName}");

// Using Spans.
ReadOnlySpan<char> namesAsSpan = name.AsSpan();
ReadOnlySpan<char> firstNameSpan = namesAsSpan[0..lengthOfFirst];
ReadOnlySpan<char> lastNameSpan = namesAsSpan[^lengthOfLast..];

WriteLine($"First: {firstName}, Last: {lastName}");

ReadOnlySpan<char> text = "12+23+456".AsSpan();
int sum = 0;
foreach (Range r in text.Split('+'))
{
  sum += int.Parse(text[r]);
}
WriteLine($"Sum using Split: {sum}");

WriteLine($"First: {firstName}, Last: {lastName}");

ReadOnlySpan<char> multi = "3*12*43".AsSpan();
int result = 1;
foreach (Range r in multi.Split('*'))
{
  result *= int.Parse(multi[r]);
}
WriteLine($"Result using Split: {result}");