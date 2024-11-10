public class Kata
{
    public static string Encode(string str)
    {
        string res = "";
        for (int i = 0; i < str.Length; i++)
        {
            if ("GA".Contains(char.ToUpper(str[i])))
            {
                if (char.IsUpper(str[i]))
                {
                    if (str[i] == 'G')
                    {
                        res += 'A';
                    }
                    else
                    {
                        res += 'G';
                    }
                }
                else
                {
                    if (str[i] == 'g')
                    {
                        res += 'a';
                    }
                    else
                    {
                        res += 'g';
                    }
                }
            }
            else if ("DE".Contains(char.ToUpper(str[i])))
            {
                if (char.IsUpper(str[i]))
                {
                    if (str[i] == 'D')
                    {
                        res += 'E';
                    }
                    else
                    {
                        res += 'D';
                    }
                }
                else
                {
                    if (str[i] == 'd')
                    {
                        res += 'e';
                    }
                    else
                    {
                        res += 'd';
                    }
                }
            }
            else if ("RY".Contains(char.ToUpper(str[i])))
            {
                if (char.IsUpper(str[i]))
                {
                    if (str[i] == 'R')
                    {
                        res += 'Y';
                    }
                    else
                    {
                        res += 'R';
                    }
                }
                else
                {
                    if (str[i] == 'r')
                    {
                        res += 'y';
                    }
                    else
                    {
                        res += 'r';
                    }
                }
            }
            else if ("PO".Contains(char.ToUpper(str[i])))
            {
                if (char.IsUpper(str[i]))
                {
                    if (str[i] == 'P')
                    {
                        res += 'O';
                    }
                    else
                    {
                        res += 'P';
                    }
                }
                else
                {
                    if (str[i] == 'p')
                    {
                        res += 'o';
                    }
                    else
                    {
                        res += 'p';
                    }
                }
            }
            else if ("LU".Contains(char.ToUpper(str[i])))
            {
                if (char.IsUpper(str[i]))
                {
                    if (str[i] == 'L')
                    {
                        res += 'U';
                    }
                    else
                    {
                        res += 'L';
                    }
                }
                else
                {
                    if (str[i] == 'l')
                    {
                        res += 'u';
                    }
                    else
                    {
                        res += 'l';
                    }
                }
            }
            else if ("KI".Contains(char.ToUpper(str[i])))
            {
                if (char.IsUpper(str[i]))
                {
                    if (str[i] == 'K')
                    {
                        res += 'I';
                    }
                    else
                    {
                        res += 'K';
                    }
                }
                else
                {
                    if (str[i] == 'k')
                    {
                        res += 'i';
                    }
                    else
                    {
                        res += 'k';
                    }
                }
            }
            else
            {
                res += str[i];
            }
        }
        return res;

        // Alternative
        // var s = "GDRPLKgdrplkAEYOUIaeyoui";
        // var t = "AEYOUIaeyouiGDRPLKgdrplk";
        // return string.Concat(str.Select(x => s.IndexOf(x) < 0 ? x : t[s.IndexOf(x)]));
    }

    public static string Decode(string str)
    {
        return Encode(str);
    }

    public static void Main()
    {
        Console.WriteLine(Encode("Ala has a cat"));
        Console.WriteLine(Decode("Gug hgs g cgt"));
    }
}