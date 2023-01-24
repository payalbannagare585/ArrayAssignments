using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class ClassDepartment
    {
        static void Main(string[] args)
        {
            Department[] department =
            {
               
                new Department{DId=01,DName="Java Depatment",Location="Hydrabad"},
                new Department{DId=02,DName="C#.Net Department",Location="Banglore"},
                new Department{DId=03,DName="Python Department",Location="Delhi"},
                new Department{DId=04,DName=" Artificial Machine Lerning Department",Location="Kolkata"},
                new Department{DId=05,DName="Cyber Security Department",Location="Chennai"}

            };
            foreach (Department d in department)
            {
                Console.WriteLine(d);
            }
        }



    }
}
