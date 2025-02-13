using Packt.Shared;

Person harry = new()
{
  Name = "Harry",
  Born = new(year: 2001, month: 3, day: 25,
    hour: 0, minute: 0, second: 0, offset: TimeSpan.Zero)
};

harry.WriteToConsole();

// Implementing functionality using methods.
Person john = new() { Name = "John" };
Person matthew = new() { Name = "Matthew" };
Person peter = new() { Name = "Peter" };

// Call the instance method to pledge John and Matthew.
john.Pledge(matthew);

// Call the static method to pledge John and Peter.
//Person.Pledge(matthew, peter);
if (matthew + peter)
{
  WriteLine($"{matthew.Name} and {peter.Name} successfully got sworn.");
}

john.OutputBrothers();
matthew.OutputBrothers();
peter.OutputBrothers();

// Call the instance method to create an agape.
Person agape1 = john.ProcreateWith(matthew);
agape1.Name = "Joy";
WriteLine($"{agape1.Name} was born on {agape1.Born}");
Person agape2 = Person.Procreate(matthew, peter);
agape2.Name = "Peace";
// Use the * operator to "multiply".
Person agape3 = john * matthew;
agape3.Name = "Mercy";
Person agape4 = matthew * peter;
agape4.Name = "Sincerity";
john.WriteChildrenToConsole();
peter.WriteChildrenToConsole();
matthew.WriteChildrenToConsole();

for (int i = 0; i < matthew.Children.Count; i++)
{
  WriteLine(format: "   {0}'s child #{1} is named \"{2}\".",
    arg0: matthew.Name, arg1: i,
    arg2: matthew.Children[i].Name);
}

// Non-generic lookup collection.
System.Collections.Hashtable lookupObject = new();
lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");

int key = 2; // Look up the value that has 2 as its key.
WriteLine(format: "Key {0} has value: {1}",
  arg0: key,
  arg1: lookupObject[key]);
// Look up the value that has harry as its key.
WriteLine(format: "Key {0} has value: {1}",
  arg0: harry,
  arg1: lookupObject[harry]);

// Define a generic lookup collection.
Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
lookupIntString.Add(key: 4, value: "Delta");

key = 3;
WriteLine(format: "Key {0} has value: {1}",
  arg0: key,
  arg1: lookupIntString[key]);

// Assign the method to the Shout delegate.
harry.Shout += Harry_Shout;
harry.Shout += Harry_Shout_2;
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

Person?[] people =
{
  null,
  new() { Name = "Simon" },
  new() { Name = "Jenny" },
  new() { Name = "Adam" },
  new() { Name = null},
  new() { Name = "Richard" }
};
OutputPeopleNames(people, "Initial list of people.");
Array.Sort(people, new PersonComparer());
OutputPeopleNames(people, "After sorting using PersonComparer's IComparer implementation:");

Employee thomas = new()
{
  Name = "Thomas Jones",
  Born = new(year: 1990, month: 7, day: 28,
    hour: 0, minute: 0, second: 0, offset: TimeSpan.Zero)
};

thomas.WriteToConsole();

thomas.EmployeeCode = "TJ001";
thomas.HireDate = new(year: 2014, month: 11, day: 23);
WriteLine($"{thomas.Name} was hired on {thomas.HireDate:yyyy-MM-dd}");

WriteLine(thomas.ToString());

Employee aliceInEmployee = new()
{ Name = "Alice", EmployeeCode = "AA123" };

Person aliceInPerson = aliceInEmployee;
aliceInEmployee.WriteToConsole();
aliceInPerson.WriteToConsole();
WriteLine(aliceInEmployee.ToString());
WriteLine(aliceInPerson.ToString());

if (aliceInPerson is Employee explicitAlice)
{
  WriteLine($"{nameof(aliceInPerson)} is an Employee.");
  // Safely do something with explicitAlice.
}

Employee? aliceAsEmployee = aliceInPerson as Employee;
if (aliceAsEmployee is not null)
{
  WriteLine($"{nameof(aliceInPerson)} as an Employee.");
  // Safely do something with aliceAsEmployee.
}

try
{
  thomas.TimeTravel(when: new(1999, 12, 31));
  thomas.TimeTravel(when: new(1950, 12, 25));
}
catch (PersonException ex)
{
  WriteLine(ex.Message);
}

string email1 = "pamela@test.com";
string email2 = "ian&test.com";
WriteLine("{0} is a valid email address: {1}",
  arg0: email1,
  arg1: email1.IsValidEmail());
WriteLine("{0} is a valid email address: {1}",
  arg0: email2,
  arg1: email2.IsValidEmail());

Car car = new();
//  Chain method call.
car.SetModel("Tesla Model S").SetColor("Red");
car.PrintCarDetails();