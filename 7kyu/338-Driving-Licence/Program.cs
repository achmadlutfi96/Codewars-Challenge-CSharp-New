using System;
using System.Linq;
namespace CodeWars
{
    class Kata
    {
        public static string driver(params string[] data)
        {
            // Code here
            string id1 = data[2].Length < 5 ? data[2].PadRight(5, '9').ToUpper() : data[2].Substring(0, 5).ToUpper();
            DateOnly d = DateOnly.Parse(data[3]);
            string id2 = d.Year.ToString()[2].ToString();
            string id3 = (data[4] == "M" ? d.Month : d.Month + 50).ToString().PadLeft(2, '0');
            string id4 = d.Day.ToString().PadLeft(2, '0');
            string id5 = d.Year.ToString()[3].ToString();
            string id6 = $"{data[0].First()}{data[1].FirstOrDefault('9')}";
            string id7 = "9AA";

            return id1 + id2 + id3 + id4 + id5 + id6 + id7;

            // Alternative
            // var dt = DateTime.Parse(data[3]);
            // return (data[2].PadRight(5, '9')[..5]
            //         + $"{dt:yy}"[0]
            //         + $"{dt.Month + (data[4] == "M" ? 0 : 50):D2}"
            //         + $"{dt:dd}"
            //         + $"{dt:yy}"[1]
            //         + data[0][0]
            //         + (data[1] + '9')[..1]
            //         + "9AA").ToUpper();
        }

        public static void Main()
        {
            Console.WriteLine(driver(new string[] { "John", "James", "Smith", "01-Jan-2000", "M" }));
            Console.WriteLine(driver(new string[] { "Johanna", "", "Gibbs", "13-Dec-1981", "F" }));
            Console.WriteLine(driver(new string[] { "Andrew", "Robert", "Lee", "02-September-1981", "M" }));
        }
    }
}