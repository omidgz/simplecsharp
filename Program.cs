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

      const string connectionString = "Server=tcp:myfirstsql007.database.windows.net,1433;Initial Catalog=myazure;Persist Security Info=False;User ID=omid;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

      const string cmd = "CREATE TABLE IF NOT EXISTS Persons (Name VARCHAR(255), Age INT);";

    }
  }
}
