using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int basse;
        int height;

        Console.WriteLine("Please enter the base and height.");
        Console.WriteLine("");

        Console.Write("base: ");
        basse = Convert.ToInt32(Console.ReadLine());
        Console.Write("height: ");
        height = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Area: " + (basse * height) / 2 + "cm²");

        Console.WriteLine("\nDone.");
    }
}