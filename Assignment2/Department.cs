using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Department
    {
        public int DId { get; set; }
        public string DName { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            return $"Department details : {DId}  {DName}  {Location}";
        }
    }
}
