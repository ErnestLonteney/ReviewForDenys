using System;
using System.Collections.Generic;
using System.Text;

namespace RewiewEssensial.Extensions
{
    public static class Info
    {
        public static void Format(this IInfo info, string format)
        {
            info.Info = string.Format(format, info.UpdateInfo());
        }

        public static void Print(this IInfo info)
        {
            Console.WriteLine(info.Info);
        } 
    }
}
