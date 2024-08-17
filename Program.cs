using System;

namespace SimpleConsoleApp
{
  // Define the Person class with Name and Age properties
  public class Person
  {
    public string Name { get; set; }
    public int Age { get; set; }
  }

  class Program
  {
    static void Main(string[] args)
    {
      // Create an instance of the Person class
      Person[] people = new Person[]
      {
        new Person { Name = "Alice", Age = 30 },
        new Person { Name = "Bob", Age = 25 },
        new Person { Name = "Charlie", Age = 35 }
      };

      foreach (Person person in people)
      {
        Console.Write("Name: " + person.Name);
        Console.WriteLine("\tAge: " + person.Age);
      }
    }
  }
}
