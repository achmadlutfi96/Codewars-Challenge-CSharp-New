using System;
public class Sphere
{
    // Good Luck!
    private int radius;
    private int mass;
    public Sphere(int r, int m)
    {
        this.radius = r;
        this.mass = m;
    }

    public int GetRadius()
    {
        return radius;
    }

    public int GetMass()
    {
        return mass;
    }

    public double GetVolume()
    {
        return Math.Round( Math.PI * GetRadius() * GetRadius() * GetRadius() * 4/3, 5);
    }

    public double GetSurfaceArea()
    {
        return Math.Round(4 * Math.PI * Math.Pow(GetRadius(), 2), 5);
    }

    public double GetDensity()
    {
        return Math.Round(GetMass()/GetVolume(), 5);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Sphere sphere= new Sphere(2,50);
        Console.WriteLine(sphere.GetRadius());
        Console.WriteLine(sphere.GetMass());
        Console.WriteLine(sphere.GetVolume());
    }
}