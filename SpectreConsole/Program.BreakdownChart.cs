using Spectre.Console;

partial class Program
{
    public static void BreakdownChart()
    {
        #region

        // Create a BreakdownChart
        AnsiConsole.Write(
            new BreakdownChart()
                .Width(60)
                .AddItem("SCSS", 80, Color.Red)
                .AddItem("HTML", 28.3, Color.Blue)
                .AddItem("C#", 22.6, Color.Green)
                .AddItem("Javascript", 6, Color.Yellow)
                .AddItem("Ruby", 6, Color.LightGreen)
                .AddItem("Shell", 0.1, Color.Aqua)
        );

        AnsiConsole.Write(
            new BreakdownChart()
                .FullSize()
                .AddItem("SCSS", 80, Color.Red)
                .AddItem("HTML", 28.3, Color.Blue)
                .AddItem("C#", 22.6, Color.Green)
                .AddItem("Javascript", 6, Color.Yellow)
                .AddItem("Ruby", 6, Color.LightGreen)
                .AddItem("Shell", 0.1, Color.Aqua)
        );

        AnsiConsole.Write(
            new BreakdownChart()
                .HideTags()
                .AddItem("SCSS", 80, Color.Red)
                .AddItem("HTML", 28.3, Color.Blue)
                .AddItem("C#", 22.6, Color.Green)
                .AddItem("Javascript", 6, Color.Yellow)
                .AddItem("Ruby", 6, Color.LightGreen)
                .AddItem("Shell", 0.1, Color.Aqua)
        );

        var farmItems = new List<(string Label, double Value, Color color)>
        {
            ("Apple", 12, Color.Green),
            ("Orange", 54, Color.Orange1),
            ("Banana", 33, Color.Yellow),
        };

        AnsiConsole.Write(
            new BreakdownChart()
                .FullSize()
                .ShowPercentage()
                .AddItems(
                    farmItems,
                    (item) => new BreakdownChartItem(item.Label, item.Value, item.color)
                )
        );

        // Create a list of fruits.
        var newItems = new List<FruitTwo>
        {
            new FruitTwo("Apple", 12, Color.Green),
            new FruitTwo("Orange", 54, Color.Orange1),
            new FruitTwo("Banana", 33, Color.Yellow),
        };

        // Render chart
        AnsiConsole.Write(
            new BreakdownChart()
                .Width(60)
                .AddItem(new FruitTwo("Mango", 3, Color.Orange4))
                .AddItems(newItems)
        );

        #endregion
    }
}

// Declare Fruit that implements IBreakdownChartItem
public sealed class FruitTwo : IBreakdownChartItem
{
    public string Label { get; set; }
    public double Value { get; set; }
    public Color Color { get; set; }

    public FruitTwo(string label, double value, Color color)
    {
        Label = label;
        Value = value;
        Color = color;
    }
}
