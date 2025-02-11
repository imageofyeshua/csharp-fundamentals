using System.Globalization;
using Packt.Shared;

ConfigureConsole();

Person bob = new();

bob.Name = "Bob Smith";
bob.Born = new DateTimeOffset(
  year: 1965, month: 12, day: 22,
  hour: 16, minute: 28, second: 0,
  offset: TimeSpan.FromHours(-5)
);
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon
                | WondersOfTheAncientWorld.MausoleumAthalicarnassus
                | WondersOfTheAncientWorld.GreatPyramidOfGiza;
WriteLine(
  format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
  arg0: bob.Name,
  arg1: bob.FavoriteAncientWonder,
  arg2: (int)bob.FavoriteAncientWonder);
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

Person alice = new()
{
  Name = "Alice Jones",
  Born = new(1998, 3, 7, 16, 28, 0, TimeSpan.Zero)
};
WriteLine(format: "{0} was born on {1:d}.", arg0: alice.Name, arg1: alice.Born);

Person alfred = new Person();
// Works with all versions of C#.
alfred.Name = "Alfred";
bob.Children.Add(alfred);
// Works with C# 3 and later.
bob.Children.Add(new Person { Name = "Bella" });
// Works with C# 9 and later.
bob.Children.Add(new() { Name = "Zoe" });
WriteLine($"{bob.Name} has {bob.Children.Count} children");

for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
  WriteLine($"> {bob.Children[childIndex].Name}");
}

foreach (Person child in bob.Children)
{
  WriteLine($">> {child.Name}");
}

BankAccount.InterestRate = 0.012M; // Store a shared value in static field.
BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
WriteLine(
  format: "{0} earned {1:C} interest.",
  arg0: jonesAccount.AccountName,
  arg1: jonesAccount.Balance * BankAccount.InterestRate
);

BankAccount danielAccount = new();
danielAccount.AccountName = "Mr. Daniel";
danielAccount.Balance = 10_000_000;
WriteLine(
  format: "{0} earned {1:C} interest.",
  arg0: danielAccount.AccountName,
  arg1: danielAccount.Balance * BankAccount.InterestRate
);

// Constant fields are accessible via the type.
WriteLine($"{bob.Name} is a {Person.Race}");

// Read-only fields: Values that can be set at runtime.
WriteLine($"{bob.Name} was born on {bob.HomeSpace}");

Person blankPerson = new();
WriteLine(
  format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}",
  arg0: blankPerson.Name,
  arg1: blankPerson.HomeSpace,
  arg2: blankPerson.Instantiated
);

Person jason = new(initialName: "Jason", homeSpace: "Mars");
WriteLine(
  format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}",
  arg0: jason.Name,
  arg1: jason.HomeSpace,
  arg2: jason.Instantiated
);

/*
// Instantiate a book using object initializer syntax.
Book book = new()
{
  Isbn = "987-1892343400",
  Title = "C# 12 and .NET 8 - Modern Cross-Platform Development"
};

*/

Book book = new(isbn: "987-123456544", title: "C# 13 and .NET9")
{
  Author = "Daniel Park",
  PageCount = 987
};

WriteLine("{0}: {1} written by {2} has {3:N0} pages.",
  book.Isbn, book.Title, book.Author, book.PageCount);

bob.WriteToConsole();
WriteLine(bob.GetOrigin());
WriteLine(bob.SayHello());
WriteLine(bob.SayHelloTo("Emily"));
WriteLine(bob.OptionalParameters(3));
WriteLine(bob.OptionalParameters(3, "Jump!", 98.5));
WriteLine(bob.OptionalParameters(3, number: 51.9, command: "Hide"));
WriteLine(bob.OptionalParameters(3, "Poke!", active: false));
WriteLine(bob.OptionalParameters(number: 52.8, command: "Fly Up!", count: 7));

int a = 10;
int b = 20;
int c = 30;
int d = 40;
WriteLine($"Before: a={a}, b={b}, c={c}, d={d}");
bob.PassingParameters(a, b, ref c, out d);
WriteLine($"After: a={a}, b={b}, c={c}, d={d}");

int e = 50;
int f = 60;
int g = 70;
WriteLine($"Before: e={e}, f={f}, g={g}, h doesn't exist yet!");
bob.PassingParameters(e, f, ref g, out int h);
WriteLine($"After: e={e}, f={f}, g={g}, h={h}");
