using System;

public class Kata
{
    public static string PaginationText(int pageNumber, int pageSize, int totalProducts)
    {
        int startProduct = (pageNumber - 1) * pageSize + 1;
        int endProduct = Math.Min(pageNumber * pageSize, totalProducts); 
        return $"Showing {startProduct} to {endProduct} of {totalProducts} Products.";

    }
}