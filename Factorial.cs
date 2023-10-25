using System;
public class factorial
{
    public static void Main(string[] args)
    {
        int n, i, fact=1;
        Console.Write("Enter number to find factorial:");
        n = int.Parse(Console.ReadLine());
        for(i = 1; i <= n; i++)
        {
            fact = fact * i;
        }
        Console.Write("Factorial of "+ n +" is" + fact);
    }
}