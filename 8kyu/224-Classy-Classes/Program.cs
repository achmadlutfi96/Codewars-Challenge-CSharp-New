public class Person
{  
    public string Name { get; set; }
    public int Age { get; set; }
    public string Info{ get{return $"{Name}s age is {Age}"; }}

  public Person(string name, int age)
  {
    this.Name = name;
    this.Age = age;
  }

}

public class Program{
    public static void Main(string[] args){
        Person person = new Person("john",34);
        Console.WriteLine(person.Info);
    }
}