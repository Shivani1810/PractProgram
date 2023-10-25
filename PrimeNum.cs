using System;
public class PrimeNumber
{
    public static void Main(string[] args)
    {
        int n, i, m = 0, flag = 0;
        Console.Write("Enter the number to check Prime:");
        n = int.Parse(Console.ReadLine());
        m = n / 2;
        for(i = 2; i < m; ++i)
        {
            if(n % i == 0)
            {
                Console.Write(n + " is a not Prime Number");
                flag = 1;
                break;
            }
        }
        if(flag == 0)
            Console.Write(n + " is a Prime Number");
    }
}