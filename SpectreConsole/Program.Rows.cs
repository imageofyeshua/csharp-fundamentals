using Spectre.Console;

partial class Program
{
    public static void Rows()
    {
        #region Rows

        // Render two items on separate rows to Console.
        AnsiConsole.Write(new Rows(new Text("Item 1"), new Text("Item 2")));

        WriteLine();

        // Create a list of Items.
        List<Text> rows = [new Text("Item 1"), new Text("Item 2"), new Text("Item 3")];

        // Render each item in list on separate line.
        AnsiConsole.Write(new Rows(rows));

        WriteLine();

        // Render each item, apply separate styles to each
        List<Text> styledRows =
        [
            new Text("Item 1", new Style(Color.Aqua, Color.Black)),
            new Text("Item 2", new Style(Color.Cyan1, Color.Black)),
            new Text("Item 3", new Style(Color.Magenta1, Color.Black)),
        ];

        // Render each item in list on separate line.
        AnsiConsole.Write(new Rows(styledRows));

        #endregion
    }
}
