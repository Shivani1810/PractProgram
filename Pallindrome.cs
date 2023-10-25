using System;

public class palindrome
{
    public static void Main(string[] args)
    {
       int n, r, temp, sum = 0;
       Console.Write("Enter a number to check a palindrome: ");
       n = int.Parse(Console.ReadLine());
       temp = n;
       while(n > 0)
       {
           r = n % 10;
           sum = (sum*10) + r;
           n = n / 10;
       }
       if(temp == sum)
        Console.Write("Palindrome");
       else
       Console.WriteLine("Not a Palindrome");
    }
    
}