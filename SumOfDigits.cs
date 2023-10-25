using System;
public class SumOfDigits
{
    public static void Main(string[] args)
    {
        int sum = 0, n, rem;
        Console.Write("Enter the number:");
        n = int.Parse(Console.ReadLine());

        while(n > 0)
        {
            rem = n % 10;
            sum = sum + rem;
            n = n / 10;
        }
        Console.Write("Sum of digits of number is " + sum);
    }
}