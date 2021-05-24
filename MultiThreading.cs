using System;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing and changing the names of two threads
            Thread thread1 = new Thread(Run);
            thread1.Name = "ThreadOne";
            Thread thread2 = new Thread(Run);
            thread2.Name = "ThreadTwo";
 
            // Default priority of threads are set to Normal
            Console.WriteLine("The priority of {0} is : {1} ", thread1.Name, thread1.Priority);
            Console.WriteLine("The priority of {0} is : {1} ", thread2.Name, thread2.Priority);

            // We can set the priorty of each thread
            thread1.Priority = ThreadPriority.BelowNormal;
            thread2.Priority = ThreadPriority.Highest;
            thread1.Start();
            thread2.Start();

            // Print the new priotity of thread
            Console.WriteLine("The priority of {0} is : {1} ", thread1.Name, thread1.Priority);
            Console.WriteLine("The priority of {0} is : {1} ", thread2.Name, thread2.Priority);
        }
        public static void Run()
        {
            // Sleep for 0.5 seconds.
            Thread.Sleep(500);
        }
    }
}
