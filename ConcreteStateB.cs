﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class ConcreteStateB : State
    {
        void State.Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
}
