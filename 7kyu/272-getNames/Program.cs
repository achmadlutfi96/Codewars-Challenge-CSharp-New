using System.Linq;
public class Kata
{
  public static string[] GetNames(Person[] data)
  {
    return data.Select(x=>x.Name).ToArray();
  }

}

public class Person
{
  public int Age;
  public string Name;

  public Person(string name = "John", int age = 21)
  {
    Age = age;
    Name = name;
  }
}