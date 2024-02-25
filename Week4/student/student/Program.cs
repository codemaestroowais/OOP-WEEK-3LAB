using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
           Console.WriteLine( student.calculateMerit());
            Console.WriteLine(student.isHostelite());


        }
    }
}
