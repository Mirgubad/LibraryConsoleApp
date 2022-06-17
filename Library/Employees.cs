using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Employees
    {
        public string  Name { get; set; }
        public string  SurName { get; set; }
        public int Experience { get; set; }
        public int Age { get; set; }
        public int EId { get;  }
        private static int _eId=1;
        public Employees()
        {
            EId = ++_eId;
           
        }
    }
}
