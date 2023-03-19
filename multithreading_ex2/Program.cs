using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Create a new thread and start it
        Thread t = new Thread(new ThreadStart(DoWork));
        t.Start();

        // Do some work on the main thread
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Main thread: {0}", i);
            Thread.Sleep(1000);
        }

        Console.ReadLine();
    }

    static void DoWork()
    {
        // Do some work on the new thread
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Worker thread: {0}", i);
            Thread.Sleep(1000);
        }
        Console.ReadLine();
    }
}
