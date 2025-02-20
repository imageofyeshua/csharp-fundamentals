using Spectre.Console;

partial class Program
{
    public static void BarChart()
    {
        #region Bar Chart

        AnsiConsole.Write(
            new BarChart()
                .Width(60)
                .Label("[green bold underline]Number of fruits[/]")
                .CenterLabel()
                .AddItem("Apple", 12, Color.Yellow)
                .AddItem("Orange", 54, Color.Green)
                .AddItem("Banana", 33, Color.Red)
        );

        // Create a list of fruits.
        var items = new List<(string Label, double Value)>
        {
            ("Apple", 12),
            ("Orange", 54),
            ("Banana", 33),
        };

        // Render bar chart.
        AnsiConsole.Write(
            new BarChart()
                .Width(60)
                .Label("[green bold underline]Number of fruits[/]")
                .CenterLabel()
                .AddItems(items, (item) => new BarChartItem(item.Label, item.Value, Color.Yellow))
        );

        // Create a list of fruits from class.
        var fruitItems = new List<Fruit>
        {
            new Fruit("Apple", 12, Color.Aqua),
            new Fruit("Orange", 54, Color.DeepSkyBlue4),
            new Fruit("Banana", 33, Color.Gold3),
        };

        // Render bar chart.
        AnsiConsole.Write(
            new BarChart()
                .Width(70)
                .Label("[green bold underline]Number of fruits[/]")
                .CenterLabel()
                .AddItem(new Fruit("Mango", 3, Color.Khaki3))
                .AddItems(fruitItems)
        );
        WriteLine();

        #endregion
    }
}

// Fruit class implementing IBarChartItem
public sealed class Fruit : IBarChartItem
{
    public string Label { get; set; }
    public double Value { get; set; }
    public Color? Color { get; set; }

    public Fruit(string label, double value, Color? color = null)
    {
        Label = label;
        Value = value;
        Color = color;
    }
}
