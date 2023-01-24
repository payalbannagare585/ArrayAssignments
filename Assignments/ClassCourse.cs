using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class ClassCourse
    {
        static void Main(string[] args)
        {
            Course[] products =
            {
                new Course{CId=1,CName="Java",fees=3000},
                new Course{CId=2,CName="C#.Net",fees=5400},
                new Course{CId=3,CName="Python",fees=5050},
                new Course{CId=4,CName=" Artificial Machine Lerning",fees=4000},
                new Course{CId=5,CName="Cyber Security",fees=3000}

            };
            foreach (Course c in products)
            {
                Console.WriteLine(c);
            }
        }


    }
}
