public class Person
{
    // TODO
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    public Person(string firstName = "John", string lastName = "Doe", int age = 0, string gender = "Male"){
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Gender = gender;
    }

    public string SayFullName(){
        return $"{this.FirstName} {this.LastName}";
    }

    public static string GreetExtraTerrestrials(string raceName){
        return $"Welcome to Planet Earth {raceName}";
    }
}