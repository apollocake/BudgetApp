﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp
{
    public interface IBudgetItem
    {
        string Name { get; set; }
        decimal Cost { get; set; }
        Cycle Cycle { get; set; }
    }
}
