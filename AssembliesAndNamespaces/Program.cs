using System.Xml.Linq; // To use XDocument

XDocument doc = new();

string s1 = "Hello";
string s2 = "World";
WriteLine($"{s1} {s2}");

WriteLine($"Environment.Is64BitProcess = {Environment.Is64BitProcess}");
WriteLine($"Environment.Is64BitOperatingSystem = {Environment.Is64BitOperatingSystem}");
WriteLine($"int.MaxValue = {int.MaxValue:N0}");
WriteLine($"nint.MaxValue = {nint.MaxValue:N0}");
