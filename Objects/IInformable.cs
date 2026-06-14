using System;
using System.Collections.Generic;
using System.Text;

namespace Objects
{
    interface IInformable
    {
        public string? Number { get; set; }
        public string? Name { get; }

        public void PrintInfo();
    }
}
