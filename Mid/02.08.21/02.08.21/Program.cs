using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._08._21
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 3, z;
            Console.WriteLine("Numbers are : "+x+"," +y);
            Console.WriteLine("Numbers are : {0},{1}", x, y);
            Console.WriteLine("The addition of x and y is {0}", x + y);
            Console.WriteLine("The subtraction of x and y is {0}", x - y);
            Console.WriteLine("The multiplication of x and y is {0}", x * y);
            Console.WriteLine("The division of x and y is {0}", x / y);

            string a = Console.ReadLine();
            z = Int32.Parse(a);
            Console.WriteLine("The inserted number is " + z);

            //int i, n, sum = 0;

            //Console.WriteLine("Input number of terms : ");
            //n = 
            //n = Convert.ToInt32(Console.ReadLine());
            //Console.Write("\nThe even numbers are :");
            //for (i = 1; i <= n; i++)
            //{
            //Console.Write("{0} ", 2 * i);
            //sum += 2 * i;
            //}
            //Console.Write("The sum of even numbers : {1} ", n, sum);
        }
    }
}
