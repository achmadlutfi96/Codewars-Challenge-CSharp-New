namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public bool AreEquallyStrong(int YourLeft, int YourRight, int FriendsLeft, int FriendsRight){
          //coding and coding..
          if(!((YourLeft == FriendsLeft || YourLeft == FriendsRight) && (YourRight == FriendsLeft || YourRight == FriendsRight))){
            return false;
          }
          return (YourLeft+YourRight) == (FriendsLeft+FriendsRight);

        //   Alternative
        // int[]yourPower = {yourLeft, yourRight};
        //   int[]friendsPower = {friendsLeft, friendsRight};
        //   return yourPower.Max()==friendsPower.Max() && yourPower.Min()==friendsPower.Min();
        }
    }
}