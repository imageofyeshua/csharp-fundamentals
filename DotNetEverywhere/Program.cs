WriteLine("I can run everywhere!");
WriteLine($"OS Version is {Environment.OSVersion}");

if (OperatingSystem.IsLinux())
{
  WriteLine("I am Linux.");
}
else if (OperatingSystem.IsMacOS())
{
  WriteLine("I am MacOS.");
}
else if (OperatingSystem.IsWindowsVersionAtLeast(
  major: 10, build: 22000
))
{
  WriteLine("I am Windows 11.");
}
else if (OperatingSystem.IsWindowsVersionAtLeast(major: 10))
{
  WriteLine("I am Windows 10.");
}
else
{
  WriteLine("I am some other mysterious OS.");
}
WriteLine("End of OS Check");

// Publish Command
// dotnet publish -c Release -r linux-x64 --self-contained
// dotnet publish -c Release -r osx-arm64 --self-contained
// dotnet publish -c Release -r win-x64 --self-contained
// dotnet publish -c Release -r win-x64 --self-contained /p:PublishSingleFile=true

// Publish single file
// dotnet publish -r win-x64 -c Release --no-self-contained /p:PublishSingleFile=true