﻿using System.Globalization; // to use CultureInfo
using static System.Convert;

int a = 10;
double b = a;
WriteLine($"a is {a}, b is {b}");

double c = 9.8;
int d = (int)c;
WriteLine($"c is {c}, d is {d}");

long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0}, f is {f:N0}");

// e = long.MaxValue;
e = 5_000_000_000;
f = (int)e;
WriteLine($"e is {e:N0}, f is {f:N0}");

WriteLine("{0, 12} {1, 34}", "Decimal", "Binary");
WriteLine("{0, 12} {0, 34:B32}", int.MaxValue);
for (int i = 8; i >= -8; i--)
{
    WriteLine("{0, 12} {0, 34:B32}", i);
}
WriteLine("{0, 12} {0, 34:B32}", int.MinValue);

long r = 0b_101000101010001100100111010100101010;
int s = (int)r;
WriteLine($"{r,38:B38} = {r}");
WriteLine($"{r,38:B32} = {s}");

double g = 9.8;
int h = ToInt32(g); // converting rounds the double
WriteLine($"g is {g}, h is {h}");

double[,] doubles =
{
    { 9.49, 9.5, 9.51 },
    { 10.49, 10.5, 10.51 },
    { 11.49, 11.5, 11.51 },
    { 12.49, 12.5, 12.51 },
    { -12.49, -12.5, -12.51 },
    { -11.49, -11.5, -11.51 },
    { -10.49, -10.5, -10.51 },
    { -9.49, -9.5, -9.51 },
};
WriteLine($"|  double  |  ToInt32  |  double  |  ToInt32  |  double  |  ToInt32  |");
for (int x = 0; x < 8; x++)
{
    for (int y = 0; y < 3; y++)
    {
        Write($"|  {doubles[x, y],6}  |  {ToInt32(doubles[x, y]),7}");
    }
    WriteLine("|");
}
WriteLine();

foreach (double n in doubles)
{
    WriteLine(
        format: "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
        arg0: n,
        arg1: Math.Round(value: n, digits: 0, mode: MidpointRounding.AwayFromZero)
    );
}

int number = 12;
WriteLine(number.ToString());
bool boolean = true;
WriteLine(boolean.ToString());
DateTime now = DateTime.Now;
WriteLine(now.ToString());
object me = new();
WriteLine(me.ToString());

// allocate an array of 128 bytes.
byte[] binaryObject = new byte[128];

// populate the array with random bytes.
Random.Shared.NextBytes(binaryObject);
WriteLine("Binary Object as bytes:");
for (int index = 0; index < binaryObject.Length; index++)
{
    Write($"{binaryObject[index]:X2} "); // :X2 for hexadecimal notation
}
WriteLine();

// convert the array to Base64 string and output as text.
string encoded = ToBase64String(binaryObject);
WriteLine($"Binary Object as Base64: {encoded}");

// set the current culture to make sure date parsing works.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
int friends = int.Parse("27");
DateTime birthday = DateTime.Parse("4 June 1980");
WriteLine($"I have {friends} friends to invite to my party");
WriteLine($"My birthday is {birthday}");
WriteLine($"My birthday is {birthday:D}");

bool success = int.TryParse("123", out int num);
WriteLine($"Parsed Int: {num}");
bool result = Uri.TryCreate(
    "https://localhost:5000/api/customers",
    UriKind.Absolute,
    out Uri? serviceUrl
);
WriteLine($"Service URL: {serviceUrl}");
