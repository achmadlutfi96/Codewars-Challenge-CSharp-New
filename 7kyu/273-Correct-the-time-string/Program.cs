using System;
using System.Text.RegularExpressions;
public static class Time
{
  public static string? Correct(string timeString)
  { 
    if(timeString == null){
        return null;
    }
    if(timeString.Length == 0){
        return "";
    }
    if(!Regex.IsMatch(timeString, @"\d\d:\d\d:\d\d")){
        return null;
    }
    int[] time = timeString.Split(":").Select(x=> Convert.ToInt32(x)).ToArray();
    int s = time[2] > 59 ? time[2] % 60 : time[2];
    time[1] += time[2] > 59 ? 1 : 0;
    int m = time[1] > 59 ? time[1] % 60 : time[1];
    time[0] += time[1] > 59 ? 1 : 0;
    int h = time[0] > 23 ? time[0] % 24 : time[0];
    return $"{h:D2}:{m:D2}:{s:D2}";

    // Alternative
    // if (string.IsNullOrEmpty(timeString)) return timeString;
    // if (!Regex.IsMatch(timeString, @"(\d{2}):(\d{2}):(\d{2})")) return null;
    // var t = timeString.Split(':').Select(int.Parse).ToArray();
    // return new TimeSpan(t[0], t[1], t[2]).ToString(@"hh\:mm\:ss");
  }

  public static void Main(){
    Console.WriteLine(Correct("19:99:99"));
  }
}