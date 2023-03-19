using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_ex1
{
    internal class Program
    {
        // step1: complete class level  code.
        public class test
        {
            public void p1()
            {
                Console.WriteLine("This is p1 method.");
            }
        }

        // step2: create delegate.
        // access modifier deligate returntype delegatename()
        public delegate void dname();
        static void Main(string[] args)
        {
            // step3: create object to class
            test t1 = new test();

            // step4: create object to delegate and pass the method output here.
            dname d1 = new dname(t1.p1);

            // step5: call the delegate object.
            d1();

            Console.ReadLine();
        }
    }
}
