using System;
public class ArmstrongNum 
{
    public static void Main(string[] args)
    {
        int num, rem, sum = 0, temp;
        Console.WriteLine("Enter the Number = ");
        num = int.Parse(Console.ReadLine());
        temp = num;
        while(num > 0)
        {
            rem = num % 10;
            sum = sum + (rem*rem*rem);
            num = num / 10;
        }
        if(temp == num)
            Console.WriteLine(temp + "is a Armstrong Number");
        else    
            Console.WriteLine(temp + "is not a Armstrong Number");
            
        Console.ReadKey();
    }
}