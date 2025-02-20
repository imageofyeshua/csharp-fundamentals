using Spectre.Console;

partial class Program
{
  public static void Calendar()
  {
    var calendar = new Calendar(2020, 10);
    AnsiConsole.Write(calendar);

    // Culture specific.
    var calendarKorean = new Calendar(2025, 2);
    calendarKorean.Culture("ko-KR");
    AnsiConsole.Write(calendarKorean);

    // Hide Header.
    var calendarNoHeader = new Calendar(2026,2);
    calendarNoHeader.HideHeader();
    AnsiConsole.Write(calendarNoHeader);

    // Header style.
    var calendarHeaderStyle = new Calendar(2027, 2);
    calendarHeaderStyle.HeaderStyle(Style.Parse("red bold"));
    AnsiConsole.Write(calendarHeaderStyle);

    // Calendar events
    var calendarEvent = new Calendar(2028, 2);
    calendarEvent.AddCalendarEvent(2028, 2, 24);
    calendarEvent.HighlightStyle(Style.Parse("red bold"));
    AnsiConsole.Write(calendarEvent);
  }
}
