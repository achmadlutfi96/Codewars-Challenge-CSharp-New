using System;
public class Kata
{
  public static string HeavyMetalUmlauts(string boringText)
  {
    return boringText.Replace('A','Ä')
                    .Replace('O' , 'Ö')
                    .Replace('a' , 'ä')
                    .Replace('o' , 'ö')
                    .Replace('E' , 'Ë')
                    .Replace('U' , 'Ü')
                    .Replace('e' , 'ë')
                    .Replace('u' , 'ü')
                    .Replace('I' , 'Ï')
                    .Replace('Y' , 'Ÿ')
                    .Replace('i' , 'ï')
                    .Replace('y' , 'ÿ');

    // Alternative
    // string strfrom ="AEIOUYaeiouy";
    // string strto =  "ÄËÏÖÜŸäëïöüÿ";
    // for (int i=0; i < strfrom.Length;i++)
    //   boringText = boringText.Replace(strfrom[i],strto[i]);
    // return boringText;
  }  
}