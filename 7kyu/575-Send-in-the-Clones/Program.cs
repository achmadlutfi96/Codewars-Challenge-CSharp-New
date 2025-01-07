namespace Solution 
{
  public static class Clones
  {
    public static int[] Clonewars(int kataPerDay)
    {
        //Code it!
        int numberOfClones = 1; 
        int totalKatasSolved = 0; 
        while (kataPerDay > 0) 
        { 
            totalKatasSolved += kataPerDay * numberOfClones;
            kataPerDay--;
            if(kataPerDay > 0){
              numberOfClones*=2;
            }
        } 
        return new int[] { numberOfClones, totalKatasSolved };

        // Alternative
        // return new[] {Math.Max((int) Math.Pow(2, kataPerDay - 1), 1), (int) Math.Pow(2, kataPerDay + 1) - 2 - kataPerDay};
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(", ",Clonewars(5)));
    }
  }
}