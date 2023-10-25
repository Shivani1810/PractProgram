using System;
public class ReverseNum
{
    public static void Main(string[] args)
    {
        int n, rem, reverse = 0;
        Console.Write("Enter number to reverse:");
        n = int.Parse(Console.ReadLine());

        while(n > 0)
        {
            rem = n % 10;
            reverse = (reverse * 10) + rem;
            n = n / 10;
        }
        Console.WriteLine("Reverse number is " +reverse);

    }
}