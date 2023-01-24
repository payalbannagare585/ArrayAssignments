using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Course
    {
        public int CId { get; set; }
        public string CName { get; set; }
        public int fees { get; set; }

        public override string ToString()
        {
            return $"Product details : {CId}  {CName}  {fees}";
        }
    }


}

