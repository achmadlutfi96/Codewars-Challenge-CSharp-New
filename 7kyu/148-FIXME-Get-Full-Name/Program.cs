public class Dinglemouse
{
  private string firstName;
  private string lastName;
  public string FullName
  {
    get
    {
      return (firstName+" "+lastName).Trim();
    }
  }
  
  public Dinglemouse(string firstName, string lastName)
  {
    this.firstName = firstName;
    this.lastName = lastName;
  }
}