static class CodeWars
{
    public static (string color, long position) RedKnight(int knight, long pawn)
    {
      // Your solution goes here
      return ((pawn-knight)%2==1 ? "Black":"White", pawn*2);
    }

}