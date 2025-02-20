namespace AboutMyEnvironment;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Environment.CurrentDirectory);
        Console.WriteLine(Environment.OSVersion.VersionString);
        Console.WriteLine("Namespace: {0}", typeof(Program).Namespace ?? "<null>");

        string firstName = "Daniel";
        string lastName = "Park";
        string horizontalLine = new('-', count: 74);
        string grinningEmoji = char.ConvertFromUtf32(0x1F600);
        Console.WriteLine(horizontalLine);
        Console.WriteLine(firstName + " " + lastName);
        Console.WriteLine(horizontalLine);

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine(grinningEmoji);
        string genesis = "\u8d77\u521d\uff0c\u3000\u4e0a\u5e1d\u5275\u9020\u5929\u5730\u3002";
        Console.WriteLine(genesis);

        string filePath = @"C:\televisions\lies\oneverything.txt";
        Console.WriteLine(filePath);

        string xml = """
            <person age="47">
            	<first_name>Daniel</first_name>
            </person>
            """;
        Console.WriteLine(xml);

        var person = new { FirstName = "Jason", Age = 52 };
        string json = $$"""
            {
            	"first_name": "{{person.FirstName}}",
            	"age": {{person.Age}},
            	"calculation": "{{{1 + 2}}}"
            }
            """;
        Console.WriteLine(json);
    }
}
