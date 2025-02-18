using System.Text.Json.Serialization;

namespace Packt.Shared;

public class Book
{
  public Book(string title)
  {
     Title = title; 
  }
  
  // Properties.
  public string Title { get; set; }
  public string? Author { get; set; }

  // Fields.
  [JsonInclude]
  public DateTime PublishDate;
  [JsonInclude]
  public DateTimeOffset Created;
  public ushort Pages;
}
