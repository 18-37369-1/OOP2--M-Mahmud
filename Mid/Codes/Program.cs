using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello today");
            int a = 10;
            Console.WriteLine("the variable is " + a);
            float f = 10.578f;
            Console.WriteLine("the value of f is {0}", f);
            Console.WriteLine("the value is {0} and f is {1}", a, f);

            // implicit casting
            short s = 10; //a cup of tea
            int i; // an empty catlee
            i = s;

            //explicit casting
            int j = 2454; // a katlee full of tea
            short h;
            h = (short) j;

            int m = 4; //half cup tea
            short n; //an empty cup
            n = (short) m;

            Console.WriteLine("j={0}\nh = {1}\n\nm={2}\nn= {3}", j, h, m, n);


        }
    }
}
