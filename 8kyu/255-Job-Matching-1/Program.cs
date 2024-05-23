// using StriveObjects;
using System;

public class Strive
{
  public static bool Match(Candidate c, Job j)
  {
    if(c.MinSalary == null || j.MaxSalary == null){
         throw new NotImplementedException();
       }
        return c.MinSalary-(c.MinSalary*0.1) <= j.MaxSalary;
  }
}

public class Candidate{
    public int? MinSalary { get; set; }
    public Candidate(int minSalary) { MinSalary = minSalary;}
}

public class Job{
    public int? MaxSalary { get; set; }
    public Job(int maxSalary) { MaxSalary = maxSalary;}
}