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