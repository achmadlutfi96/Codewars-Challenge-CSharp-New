using System;
public class Dinglemouse
{
    public static (int, int) OwnedCatAndDog(int catYears, int dogYears)
    {
        // Your code here!
        int cat = 0;
        int dog = 0;
        if(catYears >= 15){
            cat++;
            catYears-=15;
            if(catYears >= 9){
                cat++;
                catYears -= 9;
                if(catYears >= 4){
                    cat += catYears/4;
                }
            }
        }
        if(dogYears >= 15){
            dog++;
            dogYears-=15;
            if(dogYears >= 9){
                dog++;
                dogYears -= 9;
                if(dogYears >= 5){
                    dog += dogYears/5;
                }
            }
        }

        return (cat, dog);

        // Alternative
        // return (catYears < 15 ? 0 : catYears < 24 ? 1 : (catYears - 24) / 4 + 2,
        // dogYears < 15 ? 0 : dogYears < 24 ? 1 : (dogYears - 24) / 5 + 2);
    }

    public static void Main(){
        Console.WriteLine(string.Join(",", OwnedCatAndDog(56, 64)));
        Console.WriteLine(string.Join(",", OwnedCatAndDog(46, 57)));
    }
}