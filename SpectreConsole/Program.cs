using Spectre.Console;

public static class Program
{
  public static void Main(string[] args)
  {
    #region Columns

    AnsiConsole.Markup("[underline red]Hello[/] World!");

    WriteLine();

    // Render two items on separate columns to Console.
    AnsiConsole.Write(new Columns(
      new Text("Item 1"),
      new Text("Item 2")
    ));

    // Create a list of Items.
    var columns = new List<Text>()
    {
      new Text("Item 1"),
      new Text("Item 2"),
      new Text("Item 3")
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

    #region Table

    // Create a table.
    var table = new Table();

    // Add some columns
    table.AddColumn("Abide");
    table.AddColumn(new TableColumn("in Hope").Centered());

    // Add some rows
    table.AddRow("Kingdom", "[green]Heaven[/]");
    table.AddRow(new Markup("[blue]Coming[/]"), new Panel("Soon"));

    // Sets the border
    // table.Border(TableBorder.None);
    // table.Border(TableBorder.Ascii);
    table.Border(TableBorder.Square);
    // table.Border(TableBorder.Rounded);

    // Table will take up as much space as it can
    // with respect to other things.
    // table.Expand();

    // Table will take up minimal width.
    table.Collapse();

    // Hides all column headers.
    // table.HideHeaders();

    // Sets the table width to 50 cells.
    table.Width(50);

    // Table alignments.
    // table.Alignment(Justify.Right);
    // table.RightAligned();
    table.Centered();
    // table.LeftAligned();

    // Column appearance.
    table.Columns[0].Alignment(Justify.Right);
    table.Columns[1].Alignment(Justify.Left);
    // table.Columns[0].LeftAligned();
    // table.Columns[0].Centered();
    // table.Columns[0].RightAligned();

    // Set padding individually
    table.Columns[0].PadLeft(3);
    table.Columns[0].PadRight(5);
    table.Columns[1].PadLeft(5);

    // Or chained together
    // table.Columns[0].PadLeft(3).PadRight(5);

    // Or with the shorthand method if the left and right 
    // padding are identical. Vertical padding is ignored.
    // table.Columns[0].Padding(4, 0);

    // Disable column wrapping
    table.Columns[0].NoWrap();

    // Set the column width
    table.Columns[1].Width(15);

    // Render the table to the console.
    AnsiConsole.Write(table);

    #endregion

    #region Tree

    // Create the tree
    var root = new Tree("Root")
      .Style("white on blue")
      // .Guide(TreeGuide.Ascii)
      // .Guide(TreeGuide.Line)
      // .Guide(TreeGuide.DoubleLine)
      .Guide(TreeGuide.BoldLine);

    // Add some nodes
    var foo = root.AddNode("[yellow]Foo[/]");
    var treeTable = foo.AddNode(new Table()
      .RoundedBorder()
      .AddColumn("First")
      .AddColumn("Second")
      .AddRow("1", "2")
      .AddRow("3", "4")
      .AddRow("5", "6")
    );

    treeTable.AddNode("[blue]Baz[/]");
    foo.AddNode("Qux");

    var bar = root.AddNode("[yellow]Bar[/]");
    bar.AddNode(new Calendar(2025, 1)
      .AddCalendarEvent(2025, 1, 20)
      .HideHeader());

    root.AddNode("Label").Collapse();

    // Render the tree
    AnsiConsole.Write(root);

    #endregion
  }
}