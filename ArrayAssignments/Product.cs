﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignments
{
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }

            public override string ToString()
            {
                return $"Product details : {Id}  {Name}  {Price}";
            }
        }

    
}
