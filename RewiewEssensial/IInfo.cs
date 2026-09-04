using System;
using System.Collections.Generic;
using System.Text;

namespace RewiewEssensial
{
    public interface IInfo
    {
        string Info { get; set; }
        string UpdateInfo();
    }
}
