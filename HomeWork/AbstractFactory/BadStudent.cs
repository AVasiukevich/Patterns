﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class BadStudent : IStudent
    {
        public string WhoIsI()
        {
           return "I am BadStudent!";
        }
    }
}
