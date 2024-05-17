using System.Text.RegularExpressions;

public partial class Kata
    {
        static Dictionary<string,string> FirstName = new System.Collections.Generic.Dictionary<string, string>(){{"A", "Alpha"}, {"B", "Beta"}, {"C", "Cache"}};
        static Dictionary<string,string> Surname = new System.Collections.Generic.Dictionary<string, string>(){{"A", "Analogue"}, {"B", "Bomb"}, {"C", "Catalyst"}};
        public static string AliasGen(string fName, string lName)
        {
          // class is partial,
          // FirstName and Surname dictionaries are defined in other part of partial
          // you can access them directly here
          return Regex.IsMatch(fName[0].ToString().ToUpper(), @"[A-Z]") && Regex.IsMatch(lName[0].ToString().ToUpper(), @"[A-Z]") ? string.Join(" ", new string[]{FirstName[fName[0].ToString().ToUpper()], Surname[lName[0].ToString().ToUpper()]}) : "Your name must start with a letter from A - Z.";

          // Alternative
          // return char.IsLetter(fName[0]) && char.IsLetter(lName[0])
            // ? $"{FirstName[fName[0].ToString()]} {Surname[lName[0].ToString()]}"
            // : "Your name must start with a letter from A - Z.";
        }

        public static void Main(){
            Console.WriteLine(AliasGen("Acmaa", "Bdsmds"));
        }
    }