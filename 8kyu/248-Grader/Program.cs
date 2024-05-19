public class Kata
{
  public static char Grader(double score)
  {
    if (score <= 1 && score >= 0.9){
        return 'A';
    }else if(score < 0.9 && score >= 0.8){
        return 'B';
    }else if(score < 0.8 && score >= 0.7){
        return 'C';
    }else if(score < 0.7 && score >= 0.6){
        return 'D';
    }else{
        return 'F';
    }

    // Alternative
    // return score > 1.0 ? 'F'
        //  : score >= 0.9 ? 'A'
        //  : score >= 0.8 ? 'B'
        //  : score >= 0.7 ? 'C'
        //  : score >= 0.6 ? 'D'
        //  : 'F';
  }

  public static void Main(){
    Console.WriteLine(Grader(0.9));
  }
}