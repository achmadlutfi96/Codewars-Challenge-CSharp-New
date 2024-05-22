public class Cat : Animal
{
    public Cat(string name) : base(name)
    {

    }

    // TODO: Override Animal's Speak method
    public override string Speak()
    {
        return $"{Name} meows.";
    }
}

public class Animal
{
    protected string Name { get; set; }
    public Animal(string name)
    {
        this.Name = name;
    }
    public virtual string Speak()
    {
        return "";
    }
}