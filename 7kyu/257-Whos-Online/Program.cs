using System;
using System.Collections.Generic;

public static class Kata
{
    public static Dictionary<UserStatus, IEnumerable<string>> WhosOnline(User[] friends)
    {
        
        // throw new NotImplementedException();
        Dictionary<UserStatus, IEnumerable<string>> result = new();
        if(friends.Length == 0) {
            return result;
        }

        List<string> online = new();
        List<string> offline = new();
        List<string> away = new();
        foreach (var item in friends)
        {
            if(item.Status == UserStatus.Online && item.LastActivity > 10){
                away.Add(item.Username);
            }else if(item.Status == UserStatus.Online){
                online.Add(item.Username);
            }else{
                offline.Add(item.Username);
            }
            
        }

        if(online.Capacity > 0){
            result.Add(UserStatus.Online, online);
        }

        if(offline.Capacity > 0){
            result.Add(UserStatus.Offline, offline);
        }

        if(away.Capacity > 0){
            result.Add(UserStatus.Away, away);
        }

        return result;

        // Alternative 1
        // return friends.GroupBy(f => f.Status == UserStatus.Online && f.LastActivity > 10 ? UserStatus.Away : f.Status,
        // u => u.Username).ToDictionary(s => s.Key, s => s.AsEnumerable());

        // Alternative 2
        // return friends.Select(x => new {Status = (x.LastActivity > 10 && x.Status == UserStatus.Online) ? UserStatus.Away : x.Status, User = x})
        //           .GroupBy(x => x.Status)
        //           .ToDictionary(x => x.Key, x => x.Select(y => y.User.Username));
    }

    public static void Main()
    {
        User[] friends = new User[]
      {
        new User("David", UserStatus.Online, 10),
        new User("Lucy", UserStatus.Offline, 22),
        new User("Bob", UserStatus.Online, 104)
      };
        foreach (var item in WhosOnline(friends))
        {
            Console.WriteLine(item.Key +" " + item.Value);
        }
    }
}


// Reference:
public enum UserStatus
{
    Online,
    Offline,
    Away
}

public class User
{
    public string Username;
    public UserStatus Status;
    public int LastActivity;
    public User(string username, UserStatus status, int lastActivity)
    {
        Username = username;
        Status = status;
        LastActivity = lastActivity;
    }
}
