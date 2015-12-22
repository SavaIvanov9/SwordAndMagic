﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Console.Interfaces
{
    public interface IRenderer
    {
        void WriteLine(string message, params object[] paramaters);

        void Clear();
    }
}
