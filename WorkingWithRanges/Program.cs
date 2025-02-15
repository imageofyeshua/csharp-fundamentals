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