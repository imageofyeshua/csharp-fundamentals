using Spectre.Console;

partial class Program
{
    public static void Layout()
    {
        // Create the layout
        var layout = new Layout("Root").SplitColumns(
            new Layout("Left"),
            new Layout("Right").SplitRows(new Layout("Top"), new Layout("Bottom"))
        );

        // Update the left column
        layout["Left"].Update(
                new Panel(
                    Align.Center(
                        new Markup("Hello [green]Daniel![/]"),
                        VerticalAlignment.Middle))
                .Expand());

        // Render the layout
        AnsiConsole.Write(layout);
    }
}
