using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int trianglebase;
        int triangleheight;

        Console.WriteLine("Please enter the base and height.");
        Console.WriteLine("");

        Console.Write("base: ");
        trianglebase = Convert.ToInt32(Console.ReadLine());
        Console.Write("height: ");
        triangleheight = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Area: " + ( trianglebase * triangleheight ) / 2 + "cm²");

        Console.WriteLine("\nDone.");
    }
}