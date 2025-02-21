using Spectre.Console;

partial class Program
{
    public static void Panel()
    {
        List<Text> fruits = [new Text("Apple"), new Text("Pear"), new Text("Peach")];

        var panel = new Panel(new Rows(fruits));

        // Sets the header.
        panel.Header = new PanelHeader("Favorite Fruits");
        panel.Border = BoxBorder.Rounded;
        panel.Padding = new Padding(2, 2, 2, 2);

        AnsiConsole.Write(panel);
    }
}

