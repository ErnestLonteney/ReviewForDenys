using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractions
{
    interface IPrintable
    {
        string Name { get; }
        void Print();
    }
}
