using System;

public static class Kata
{
    public static int CheckExam(string[] arr1, string[] arr2)
    {
        int point = 0;
        for (int i = 0; i < arr1.Length; i++){
            if(arr1[i] == arr2[i]){
                point += 4;
            }else if(arr1[i] == "" || arr2[i] == ""){
                point += 0;
            }else{
                point -= 1;
            }
        }

        return point < 0 ? 0 : point;

        // Alternative
        // return Math.Max(arr2.Select((s, i) => s == "" ? 0 : s == arr1[i] ? 4 : -1).Sum(), 0);
    }

    public static void Main(){
        Console.WriteLine(CheckExam(new string[] { "a", "a", "b", "b" }, new string[] { "a", "c", "b", "d" }));
    }
}