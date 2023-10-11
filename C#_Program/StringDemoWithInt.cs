using System;
using System.Diagnostics;

namespace StringDemo
{
    class Program{
        static void main(string[] args)
        {
            int ctr = 0;
            Console.WriteLine("Loop Started");
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            for(int i = 0; i < 30000000; ++i)
            {
                ctr = ctr + 1;
            }
            stopwatch.Stop();

            Console.WriteLine("Loop Ended");
            Console.WriteLine("Loop Execution Time in MS:" + stopwatch.ElapsedMilliseconds);

            Console.ReadKey();
        }
    }
}

//OutPut: Loop Started
//        Loop Ended
//        Loop Execution Time in MS: 95

//instead of a string, we are using an integer variable. 
//As integers are not immutable, so it will not create a fresh memory location each time the loop executes instead it will use the same memory location and update its value.