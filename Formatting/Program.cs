using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

Console.WriteLine(
  format: "{0} apples cost {1:C}",
  arg0: numberOfApples,
  arg1: pricePerApple * numberOfApples
);

string formatted = string.Format(
  format: "{0} apples cost {1:C}",
  arg0: numberOfApples,
  arg1: pricePerApple * numberOfApples
);

// WriteToFile(formatted)

const string firstname = "Daniel";
const string lastname = "Park";
const string fullname = firstname + " " + lastname;
const string wholename = $"{firstname} {lastname}";
WriteLine(fullname);
WriteLine(wholename);

string appleText = "Apples";
int appleCount = 1234;
string bananaText = "Bananas";
int bananaCount = 56789;
WriteLine(
  format: "{0, -10} {1, 6}",
  arg0: "Name", arg1: "Count"
);
WriteLine(
  format: "{0, -10} {1, 6:N0}",
  arg0: bananaText,
  arg1: bananaCount
);

decimal value = 0.325M;
WriteLine("Currency: {0:C}, Percentage: {0:0.0%}", value);

/*
Write("Type your first name and press ENTER: ");
string firstName = ReadLine();
Write("Type your age and press ENTER: ");
string age = ReadLine();
WriteLine($"Hello {firstName}, you look good for {age}");

Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine(
  "Key: {0}, Char: {1}, Modifier: {2}",
  arg0: key.Key,
  arg1: key.KeyChar,
  arg2: key.Modifiers
);
*/
string rowSeparator = new string('-', count: 104);
WriteLine(rowSeparator);
WriteLine($"Type    {"Byte(s) of memory",-4} {"Min",32} {"Max",45}");
WriteLine(rowSeparator);
WriteLine($"sbyte   {sizeof(sbyte),-4} {sbyte.MinValue,45} {sbyte.MaxValue,45}");
WriteLine($"byte    {sizeof(byte),-4} {byte.MinValue,45} {byte.MaxValue,45}");
WriteLine($"short   {sizeof(short),-4} {short.MinValue,45} {short.MaxValue,45}");
WriteLine($"ushort  {sizeof(ushort),-4} {ushort.MinValue,45} {ushort.MaxValue,45}");
WriteLine($"int     {sizeof(int),-4} {int.MinValue,45} {int.MaxValue,45}");
WriteLine($"uint    {sizeof(uint),-4} {uint.MinValue,45} {uint.MaxValue,45}");
WriteLine($"long    {sizeof(long),-4} {long.MinValue,45} {long.MaxValue,45}");
WriteLine($"ulong   {sizeof(ulong),-4} {ulong.MinValue,45} {ulong.MaxValue,45}");
unsafe
{
  WriteLine($"Int128  {sizeof(Int128),-4} {Int128.MinValue,45} {Int128.MaxValue,45}");
  WriteLine($"UInt128 {sizeof(UInt128),-4} {UInt128.MinValue,45} {UInt128.MaxValue,45}");
  WriteLine($"Half    {sizeof(Half),-4} {Half.MinValue,45} {Half.MaxValue,45}");
}
WriteLine($"float   {sizeof(float),-4} {float.MinValue,45} {float.MaxValue,45}");
WriteLine($"double  {sizeof(double),-4} {double.MinValue,45} {double.MaxValue,45}");
WriteLine($"decimal {sizeof(decimal),-4} {decimal.MinValue,45} {decimal.MaxValue,45}");
WriteLine(rowSeparator);