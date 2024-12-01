public class Funcij {

	public static ulong sumin(ulong n)
	{
		  // your code
          return n * (n + 1) * (2 * n + 1) / 6;
	}
	public static ulong sumax(ulong n)
	{
		  // your 
          return n * n * n - n * (n - 1) * (2 * n - 1) / 6;
	}
	public static ulong sumsum(ulong n)
	{
		  // your code
          return sumin(n) + sumax(n);
	}
}