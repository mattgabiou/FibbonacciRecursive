// Fibonacci Processor created by Matt Gabiou on 5-18-15
// ICS 340 Programming Assignment 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibboRecursive2
{
    class Program
    {
        static void Main(string[] args)
        {
             // Start the clock
            DateTime startTime = DateTime.Now;
             
             // Vars 
            ulong userNum, fibI = 0, counter;

             // Get user input
            Console.WriteLine("Enter the number of terms");
            userNum = Convert.ToUInt64((Console.ReadLine()));
            Console.WriteLine("The {0} terms of Fibonacci series are: ", userNum);

             // Begin Processing
            for (counter = 1; counter <= userNum; counter++)
            {
                Console.WriteLine("{0}. {1:N0}", counter, Fibonacci(fibI));
                fibI++;
            }
            Console.WriteLine("\nDone!");

             // Stop Clock, Display Total Time
            DateTime endtime = DateTime.Now;
            TimeSpan totalTimeTaken = endtime.Subtract(startTime);
            Console.WriteLine("Time Taken: {0}", totalTimeTaken);
            Console.ReadKey();
        } // end main


         // Fibonacci method
        static ulong Fibonacci(ulong n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return (Fibonacci(n - 1) + Fibonacci(n - 2));
        }
    }
}

// 50 numbers took > 11 mins
