﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public interface IHtmlElement
    {
        string Name { get; set; }
        string Info { get; set; }
        string Print();
    }
}
