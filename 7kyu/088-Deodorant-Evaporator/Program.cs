public class Evaporator { 
  
  public static int evaporator(double content, double evap_per_day, double threshold) {
    double currentContent = content;
    int days = 0;
    while(currentContent > threshold /100 *content){
        currentContent -= evap_per_day/100*currentContent;
        days += 1;
    }
    return days;

    // Alternative
    // return (int)Math.Ceiling(Math.Log(threshold / 100.0) / Math.Log(1.0 - evap_per_day / 100.0));
  }

  public static void Main(){
    Console.WriteLine(evaporator(10, 10, 10));
  }
}