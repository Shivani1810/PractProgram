using System;
using System.Diagnostics;

namespace StringDemo
{
    class Program{
        static void main(string[] args)
        {
            string str = "";
            Console.WriteLine("Loop Started");

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for(int i = 0; i < 30000000; ++i)
            {
                str = Guid.NewGuid().ToString();
            }
            stopwatch.Stop();

            Console.WriteLine("Loop Ended ");
            Console.WriteLine("Loop Execution time in MS:" + stopwatch.ElapsedMilliseconds);

            Console.ReadKey();
        }
    }
}

// It approximately took 26000 milliseconds to execute the loop. Each time the loop executes, 
// it creates a fresh string object and assigns a new value to it. This is because strings are immutable in C#.