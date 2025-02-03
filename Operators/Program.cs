#region Exploring unary operators
int a = 3;
int b = a++;
WriteLine($"a is {a}, b is {b}");

int c = 3;
int d = ++c;
WriteLine($"c is {c}, d is {d}");
#endregion
WriteLine("*************************");
int e = 11;
int f = 3;
WriteLine($"e is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");
WriteLine("*************************");
double g = 11.0;
WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}");
/*
int p = 6;
p += 3; // Equivalent to: p = p + 3;
p -= 3; // Equivalent to: p = p - 3;
p *= 3; // Equivalent to: p = p * 3;
p /= 3; // Equivalent to: p = p / 3;
*/

// string? authorName = GetAuthorName() // A fictional function
// The maxLength variable will be the length of authorName if it is not null,
// or 30, if authorName is null.
// int maxLength = authorName?.Length ?? 30; 
// authorName ??= "unknown"
// authorName variable will be "unknown" if authorName was null.

WriteLine("*************************");

bool p = true;
bool q = false;
WriteLine($"AND  | p     | q     ");
WriteLine($"p    | {p & p,-5} | {p & q,-5}");
WriteLine($"p    | {q & p,-5} | {q & q,-5}");
WriteLine();
WriteLine($"OR   | p     | q     ");
WriteLine($"p    | {p | p,-5} | {p | q,-5}");
WriteLine($"p    | {q | p,-5} | {q | q,-5}");
WriteLine();
WriteLine($"XOR  | p     | q     ");
WriteLine($"p    | {p ^ p,-5} | {p ^ q,-5}");
WriteLine($"p    | {q ^ p,-5} | {q ^ q,-5}");

WriteLine("*************************");
WriteLine($"p & DoStuff() = {p & DoStuff()}");
WriteLine($"q & DoStuff() = {q & DoStuff()}");
WriteLine($"p && DoStuff() = {p && DoStuff()}");
WriteLine($"q && DoStuff() = {q && DoStuff()}");

WriteLine();
int x = 10;
int y = 6;
WriteLine($"Expression | Decimal |   Binary");
WriteLine($"-------------------------------");
WriteLine($"x          | {x,7} | {x:B8}");
WriteLine($"y          | {y,7} | {y:B8}");
WriteLine($"x & y      | {x & y,7} | {x & y:B8}");
WriteLine($"x | y      | {x | y,7} | {x | y:B8}");
WriteLine($"x ^ y      | {x ^ y,7} | {x ^ y:B8}");
WriteLine($"x << 3     | {x << 3,7} | {x << 3:B8}"); // Left-shift x by three bit columns
WriteLine($"x * 8      | {x * 8,7} | {x * 8:B8}"); // Multiply x by 8
WriteLine($"y >> 1     | {y >> 1,7} | {y >> 1:B8}"); // Right-shift y by one bit columns

static bool DoStuff()
{
  WriteLine("I am doing some stuff.");
  return true;
}