using Spectre.Console;

partial class Program
{
  public static void Columns()
  {
    #region Columns

    AnsiConsole.Markup("[underline red]Hello[/] World!");

    WriteLine();

    // Render two items on separate columns to Console.
    AnsiConsole.Write(new Columns(new Text("Item 1"), new Text("Item 2")));

    // Create a list of Items.
    var columns = new List<Text>()
    {
      new Text("Item 1"),
          new Text("Item 2"),
          new Text("Item 3"),
    };

    // Render each item in list on separate line
    AnsiConsole.Write(new Columns(columns));

    // Create a list of Items, apply separate styles to each
    var styledColumns = new List<Text>()
    {
      new Text("Item 1", new Style(Color.Red, Color.Black)),
          new Text("Item 2", new Style(Color.Green, Color.Black)),
          new Text("Item 3", new Style(Color.Grey, Color.Black)),
    };

    // Render each item in list on separate line
    AnsiConsole.Write(new Columns(styledColumns));

    #endregion

    #region Panel

    var panel = new Panel("Hello, Daniel");

    // Sets the header.
    panel.Header = new PanelHeader("How are you?");

    // Sets the border.
    //panel.Border = BoxBorder.Ascii;
    panel.Border = BoxBorder.Square;
    //panel.Border = BoxBorder.Rounded;
    //panel.Border = BoxBorder.Heavy;
    //panel.Border = BoxBorder.Double;
    //panel.Border = BoxBorder.None;

    // Sets the padding.
    panel.Padding = new Padding(2, 2, 2, 2);

    // Sets the expand property
    // panel.Expand = true;

    AnsiConsole.Write(panel);

    #endregion
  }
}
