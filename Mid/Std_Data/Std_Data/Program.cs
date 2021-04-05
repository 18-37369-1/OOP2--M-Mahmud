using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Std_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("Computer Science");
            Department d2 = new Department("Electrical Engineering");

            Student s1 = new Student("Mahmud", "37369", 3.12);
            Student s2 = new Student("Nishab", "37426", 3.46);
            Student s3 = new Student("Shadhin", "37159", 3.25);
            Student s4 = new Student("Nazmul", "37626", 3.30);

            d1.AddStudent(s1, s2);
            d2.AddStudent(s3);
            d2.AddStudent(s4);

            d1.PrintStudent();
            d2.PrintStudent();

            Console.ReadLine();
        }
    }
}
