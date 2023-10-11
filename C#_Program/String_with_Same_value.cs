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
                str = "DotNet FrameWork";
            }
            stopwatch.Stop();

            Console.WriteLine("Loop Ended");
            Console.WriteLine("Loop Execution Time in MS:" + stopwatch.ElapsedMilliseconds);

            Console.ReadKey();
        }
    }
}

//Output : Loop Started
//         Loop Ended
//         Loop Execution Time in MS: 95

// Above output it only took 95 milliseconds. 
// This is because in this case fresh objects are not created each time the loop executes. 
// Now, the question that should come to your mind is why? The answer is String intern.

// STRING INTERN: The String Intern in C# is a process that uses the same memory location if the value is the same.