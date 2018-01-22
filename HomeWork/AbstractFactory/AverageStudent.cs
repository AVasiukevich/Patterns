using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AverageStudent : IStudent
    {
        public string WhoAmI()
        {
            return "I am AverageStudent!";
        }
    }
}
