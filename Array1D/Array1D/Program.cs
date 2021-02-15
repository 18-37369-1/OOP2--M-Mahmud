using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1D
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, l=50;
            int[] a = new int[100];

            Console.WriteLine("Input the number of elements to store in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input {0} elements :", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element {0} = ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The values store into the array are : ");
            for (i = 0; i < n; i++)
            {
                Console.Write(a[i]+" ");
            }

            Console.WriteLine("\nThe values in reverse are : ");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine("\n");

            // Q2 :
            int sum=0;
            for (int x=0;x<n;x++)
            {
                sum = sum + a[x];
            }
            Console.WriteLine("The summation of the array : {0}",sum);

            // Q3 :
            int[] b = new int[a.Length];
            Console.Write("The copied array is : ");
            for (int x = 0; x < n; x++)
            {
                b[x] = a[x];
                Console.Write(b[x]+" ");
            }
            Console.WriteLine("\n");

        }
    }
}
