using System;

namespace Variables;

public class Person
{

  public string FirstName { get; set; }
  public string LastName { get; set; }
  public int Age { get; set; }
  public DateTime BirthDate { get; set; }

  public Person() { }

  public Person(string firstName, string lastName, int age)
  {
    FirstName = firstName;
    LastName = lastName;
    Age = age;
  }

}
