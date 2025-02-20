using Spectre.Console;

partial class Program
{
    public static void Rule()
    {
        // Usage.
        var rule = new Rule();
        AnsiConsole.Write(rule);

        // Title.
        var ruleTwo = new Rule("[red]Hello[/]");
        AnsiConsole.Write(ruleTwo);

        // Title alignment.
        var ruleThree = new Rule("[red]Hello[/]");
        ruleThree.Justification = Justify.Left;
        AnsiConsole.Write(ruleThree);

        var ruleFour = new Rule("[red]Hello[/]");
        ruleFour.LeftJustified();
        AnsiConsole.Write(ruleFour);

        // Styling.
        var ruleFive = new Rule("[red]Hello[/]");
        ruleFive.Style = Style.Parse("red dim");
        AnsiConsole.Write(ruleFive);

        var ruleSix = new Rule("[red]Hello[/]");
        ruleSix.RuleStyle("red dim");
        AnsiConsole.Write(ruleSix);
    }
}
