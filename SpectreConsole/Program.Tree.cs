using Spectre.Console;

partial class Program
{
  public static void Tree()
  {
  #region Tree

    // Create the tree.
    var root = new Tree("Root")
      .Style("white on blue")
      // .Guide(TreeGuide.Ascii).
      // .Guide(TreeGuide.Line).
      // .Guide(TreeGuide.DoubleLine).
      .Guide(TreeGuide.BoldLine);

    // Add some nodes.
    var foo = root.AddNode("[yellow]Foo[/]");
    var treeTable = foo.AddNode(
        new Table()
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
    bar.AddNode(new Calendar(2025, 1).AddCalendarEvent(2025, 1, 20).HideHeader());

    root.AddNode("Label").Collapse();

    // Render the tree.
    AnsiConsole.Write(root);

    #endregion
  }
}
