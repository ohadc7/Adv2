﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithmsLib
{
    public interface State
    {
        bool Equals(State s); // we overload Object's Equals method
    }
}
