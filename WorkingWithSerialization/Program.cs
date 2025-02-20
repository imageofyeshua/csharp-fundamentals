using System.Text.Json;
using System.Text.Json.Schema;
using System.Xml.Serialization;
using Packt.Shared;
using FastJson = System.Text.Json.JsonSerializer;

List<Person> people = new()
{
    new(initialSalary: 30_000M)
    {
        FirstName = "Alice",
        LastName = "Smith",
        DateOfBirth = new(year: 1974, month: 3, day: 14),
    },
    new(initialSalary: 40_000M)
    {
        FirstName = "Bob",
        LastName = "Jones",
        DateOfBirth = new(year: 1969, month: 11, day: 24),
    },
    new(initialSalary: 40_000M)
    {
        FirstName = "Bob",
        LastName = "Jones",
        DateOfBirth = new(year: 1969, month: 5, day: 4),
        Children = new()
        {
            new(initialSalary: 0M)
            {
                FirstName = "Sally",
                LastName = "Cox",
                DateOfBirth = new(year: 2012, month: 7, day: 12),
            },
        },
    },
};

SectionTitle("Serializing as XML");

XmlSerializer xs = new(type: people.GetType());

string path = Combine(CurrentDirectory, "people.xml");

using (FileStream stream = File.Create(path))
{
    xs.Serialize(stream, people);
}

OutputFileInfo(path);

SectionTitle("Deserializing XML files");

using (FileStream xmlLoad = File.Open(path, FileMode.Open))
{
    // Deserialize and cast the object graph into a "List of Person".
    List<Person>? loadedPeople = xs.Deserialize(xmlLoad) as List<Person>;

    if (loadedPeople is not null)
    {
        foreach (Person p in loadedPeople)
        {
            WriteLine("{0} has {1} children.", p.LastName, p.Children?.Count ?? 0);
        }
    }
}

SectionTitle("Serializing with JSON");

// Create a file to write to.
string jsonPath = Combine(CurrentDirectory, "people.json");

using (StreamWriter jsonStream = File.CreateText(jsonPath))
{
    //Serialize the object graph into a string.
    Newtonsoft.Json.JsonSerializer jss = new();
    jss.Serialize(jsonStream, people);
}

OutputFileInfo(jsonPath);

SectionTitle("Deserializing JSON files");

await using (FileStream jsonLoad = File.Open(jsonPath, FileMode.Open))
{
    List<Person>? loadedPeople =
        await FastJson.DeserializeAsync(utf8Json: jsonLoad, returnType: typeof(List<Person>))
        as List<Person>;
    if (loadedPeople is not null)
    {
        foreach (Person p in loadedPeople)
        {
            WriteLine("{0} has {1} children.", p.LastName, p.Children?.Count ?? 0);
        }
    }
}

SectionTitle("JSON schema exporter");
WriteLine(JsonSchemaExporter.GetJsonSchemaAsNode(JsonSerializerOptions.Default, typeof(Person)));
