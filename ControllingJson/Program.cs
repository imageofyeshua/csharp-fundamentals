using System.Text.Json;
using Packt.Shared;

Book csharpBook = new(title: "C#13 and .NET 9")
{
    Author = "Daniel Park",
    PublishDate = new(year: 2024, month: 11, day: 12),
    Pages = 876,
    Created = DateTimeOffset.UtcNow,
};

JsonSerializerOptions options = new()
{
    IncludeFields = true, // Includes all fields.
    PropertyNameCaseInsensitive = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
};

string path = Combine(CurrentDirectory, "book.json");

using (Stream fileStream = File.Create(path))
{
    JsonSerializer.Serialize(utf8Json: fileStream, value: csharpBook, options);
}

WriteLine("*** File Info ***");
WriteLine($"File: {GetFileName(path)}");
WriteLine($"Path: {GetDirectoryName(path)}");
WriteLine($"Size: {new FileInfo(path).Length:N0} bytes.");
WriteLine("/-----------------------------");
WriteLine(File.ReadAllText(path));
WriteLine("-----------------------------/");
