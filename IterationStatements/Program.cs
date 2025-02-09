using System.Collections;

// while statement
int x = 0;
while (x < 10)
{
  WriteLine(x);
  x++;
}

// do-while statement
/*
string? actualPassword = "Pa$$w0rd";
string? password;

do
{
  Write("Enter your password: ");
  password = ReadLine();
}
while (password != actualPassword);
WriteLine("Correct!");
*/

// for statement

for (int y = 0; y <= 10; y += 3)
{
  WriteLine(y);
}

// foreach statement
string[] names = { "Adam", "Steve", "Jason", "Daniel" };
foreach (string name in names)
{
  WriteLine($"{name} has {name.Length} characters.");
}

// same as foreach
IEnumerator e = names.GetEnumerator();
while (e.MoveNext())
{
  string name = (string)e.Current;
  WriteLine($"{name} has {name.Length} characters.");
}
