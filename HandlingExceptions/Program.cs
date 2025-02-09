﻿// catching exceptions
/*
WriteLine("Before parsing");
Write("What is your age? ");
string? input = ReadLine();
try
{
  int age = int.Parse(input!);
  WriteLine($"You are {age} years old.");
}
catch (OverflowException)
{
  WriteLine("Your age is a valid number format but it is either too big or small.");
}
catch (FormatException)
{
  WriteLine("The age you entered is not a valid number format.");
}
catch (Exception ex)
{
  WriteLine($"{ex.GetType()} says {ex.Message}");
}
WriteLine("After parsing");
*/

// catching with filters
/*
Write("Enter an amount: ");
string? amount = ReadLine();
if (string.IsNullOrEmpty(amount)) return;
try
{
  decimal amountValue = decimal.Parse(amount);
  WriteLine($"Amount formatted as currency: {amountValue:C}");
}
catch (FormatException) when (amount.Contains('$'))
{
  WriteLine("Amounts cannot use the dollar sign!");
}
catch (FormatException)
{
  WriteLine("Amounts must only contain digits");
}
*/

// checking for overflow
try
{
  checked
  {
    int x = int.MaxValue - 1;
    WriteLine($"Initial value: {x}");
    x++;
    WriteLine($"After incrementing:{x}");
    x++;
    WriteLine($"After incrementing:{x}");
    x++;
    WriteLine($"After incrementing:{x}");
    x++;
  }
}
catch (OverflowException)
{
  WriteLine("The code overflowed but I caught the exception");
}

unchecked
{
  int y = int.MaxValue + 1;
  WriteLine($"Initial value: {y}");
  y--;
  WriteLine($"After incrementing:{y}");
  y--;
  WriteLine($"After incrementing:{y}");
  y--;
  WriteLine($"After incrementing:{y}");
  y--;
}

// loops and overflow >> don't run
/*
int max = 500;
for (byte i = 0; i < max; i++)
{
  WriteLine(i);
}
*/

// fizzbuzz program
for (int i = 1; i <= 100; i++)
{
  if (i % 15 == 0)
  {
    Write("FizzBuzz");
  }
  else if (i % 5 == 0)
  {
    Write("Buzz");
  }
  else if (i % 3 == 0)
  {
    Write("Fizz");
  }
  else Write(i);
  Write(", ");
}