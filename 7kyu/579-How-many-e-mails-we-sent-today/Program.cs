namespace CountEmails
{
  using System;
  public static class Program
  {
    public static string CountEmails(int sent, int limit = 1000)
    {
      // your code here, please check your arguments too!
      return sent == 0 ? "No e-mails sent" : sent >= limit ? "Daily limit is reached" : $"{Math.Floor(((double)sent/limit)*100)}%";
    }
  }
}