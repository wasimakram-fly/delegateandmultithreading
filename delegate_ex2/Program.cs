using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_ex2
{
    // step1: complete class level code.
    public class test
    {
        public void p1()
        {
            Console.Write("GM");
        }
        public void p2()
        {
            Console.WriteLine("GA");
        }
    }

    // step 2: create delegate
    public delegate void dname();
    internal class Program
    {        
        static void Main(string[] args)
        {
            //step3: create object to class
            test t1 = new test();

            //step4: create object to delegate and pass the method output here
            dname d1, d2, d3, d4, d5, d6;
            d1 = new dname(t1.p1);  // GM
            d2 = new dname(t1.p2);  // GA
            d3 = d1 + d2;   // GMGA
            Console.WriteLine("From d3");
            d3();
            d4 = d3 + d3;   // GMGAGMGA
            Console.WriteLine("From d4");
            d4();
            d5 = d4 - d1;   // GMGAGA
            Console.WriteLine("From d5");
            d5();
            d6 = d5 - d3 + d2;  // GA GA
            Console.WriteLine("From d6");
            d6();
            Console.ReadKey();
        }
    }
}
