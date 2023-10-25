using System;
public class FibonacciSeries
{
    public static void Main(string[] args)
    {
        int n1=0, n2=1, n3, i, number;
        Console.ReadLine("enter the number of elements:");

        number = int.Parse(Console.ReadLine());
        for(i = 2; i < number; i++)
        {
            n3 = n1 + n2;
            Console.ReadLine(n3 + " ");
            n1 = n2;
            n2 = n3;
        }

    }
}