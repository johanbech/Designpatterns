﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
