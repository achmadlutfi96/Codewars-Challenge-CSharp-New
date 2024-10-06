public class Fibonacci
{
    public static int Fib(int n)
    {
        // your code here!
        if(n == 1){
            return 0;
        }
        if(n == 2){
            return 1;
        }

        int x = 0;
        int y = 1;
        int sum = 0;
        for(int i = 2; i <= n; i++){
            sum = x + y;
            x = y;
            y = sum;
        }

        return sum;

        // Alternative
        // if (n==1||n==2)
            // {
            //     return 1;
            // }
            // return Fib(n - 1) + Fib(n - 2);
    }

    public static void Main(){
        Console.WriteLine(Fib(10));
    }
}