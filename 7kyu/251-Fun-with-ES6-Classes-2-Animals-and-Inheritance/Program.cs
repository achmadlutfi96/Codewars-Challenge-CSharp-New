public class Shark : Animal
{
    public Shark(string name, int age, string status) : base(name, age, 0, "shark", status)
    {

    }
}

public class Cat : Animal
{
    // Do the same here as you did for Shark - define your constructor function and any other methods you need
    public Cat(string name, int age, string status) : base(name, age, 4, "cat", status)
    {

    }

    public override string Introduce()
    {
        return $"Hello, my name is {Name} and I am {Age} years old.  Meow meow!";
    }
}

public class Dog : Animal
{
    public string Master;
    // On your own now - you can do it :D
    public Dog(string name, int age, string status, string master) : base(name, age, 4, "dog", status)
    {
        this.Master = master;
    }

    public string GreetMaster(){
        return $"Hello {Master}";
    }
}

public class Animal
{
    public int Age;
    public int Legs;
    public string Name;
    public string Species;
    public string Status;

    public Animal(string name, int age, int legs, string species, string status)
    {
        this.Name = name;
        this.Age = age;
        this.Legs = legs;
        this.Species = species;
        this.Status = status;
    }

    public virtual string Introduce()
    {
        return $"Hello, my name is {this.Name} and I am {this.Age} years old.";
    }
}