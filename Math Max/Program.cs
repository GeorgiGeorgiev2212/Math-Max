//сумиране на числа и изписване на най-голямото
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Math Max 
        Console.WriteLine("Write the numbers that you need to sum!");


        int max = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());


        int largest = Math.Max(max, Math.Max(b, Math.Max(c, Math.Max(d, Math.Max(x, Math.Max(y, z))))));


        Console.WriteLine("The largest number is: " + largest);
    }
}
