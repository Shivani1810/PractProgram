using System;
public class SwapNum
{
    public static void Main(string[] args)
    {
        int a = 5, b = 10;
        Console.WriteLine("Before Swap a =" +a+"b = "+b);
        a = a * b;
        b = a / b;
        a = a / b;
        Console.WriteLine("After Swap a =" +a+ "b = "+b);
    }
}

/* 
    Using + -
    a = a + b;
    b = a - b;
    a = a - b;

    Using Third Variable
    temp = a;
    a = b;
    b = temp 
*/