using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace multithreading_ex1
{
    public class test
    {
        public static void p1()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i+"");
                Thread.Sleep(10000); // 500 miliseconds
            }
        }

        public static void p2()
        {
            for(int j = 11; j <= 20; j++)
            {
                Console.WriteLine(j + "");
                Thread.Sleep(10000);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadStart ts1 = new ThreadStart(test.p1);
            ThreadStart ts2 = new ThreadStart(test.p2);
            Thread t1 = new Thread(ts1);
            Thread t2 = new Thread(ts2);
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }
    }
}
