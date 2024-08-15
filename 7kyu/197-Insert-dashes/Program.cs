using System.Text.RegularExpressions;
public class Kata
{
  public static string InsertDash(int num)
  {
    // code me
    string res = "";
    string newNum = num.ToString();
    res+=newNum[0];
    for(int i=1; i < newNum.Length; i++){
        if(char.GetNumericValue(newNum[i])%2==1 && char.GetNumericValue(newNum[i-1])%2==1){
            res+='-';
        }
        res+=newNum[i];
    }
    return res;

    // Alternative
    // return Regex.Replace($"{num}", "([1,3,5,7,9])(?=[1,3,5,7,9])", "$1-");
  }

  public static void Main(){
    Console.WriteLine(InsertDash(454793));
  }
}