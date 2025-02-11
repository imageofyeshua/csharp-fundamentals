using System.Diagnostics.CodeAnalysis; // To use [SetsRequiredMembers].
namespace Packt.Shared;

public class Book
{
  // Needs .NET 7 or later as well aas C# 11 or later.
  public required string? Isbn;
  public required string? Title;
  // Works with any version of .NET.
  public string? Author;
  public int PageCount;
  // Constructor for use with object initializer syntax.
  public Book() { } // For use with initialization syntax.
  [SetsRequiredMembers]
  public Book(string? isbn, string? title)
  {
    Isbn = isbn;
    Title = title;
  }
}
