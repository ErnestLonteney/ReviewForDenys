using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace IndexatorsReview
{
    internal interface IInterface
    {
        string Name { get; }

        string this[int index] 
        {
            get;
        }
    }
}
