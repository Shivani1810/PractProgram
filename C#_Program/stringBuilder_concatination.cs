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
            for (int i = 0; i < 30000000; i++)
            {
                str = "Shivani Patil" + str;
            }
            stopwatch.Stop();

            Console.WriteLine("Loop Ended");
            Console.WriteLine("Loop Execution Time in MS :" + stopwatch.ElapsedMilliseconds);

            Console.ReadKey();
        }
    }
}


// The loop executes the first time, it will create a new memory location and store the value “DotNet Tutorials”. 
//For the second time, it creates another fresh memory location (fresh object) and 
//stores the value “DotNet Tutorials DotNet Tutorials” and the first memory location will be going for garbage collection. 
//And the same process will continue i.e. each time the loop executes a new memory location will be created and previous 
//ones will be going for garbage collection.

