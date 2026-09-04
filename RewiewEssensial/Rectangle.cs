using System;
using System.Collections.Generic;
using System.Text;

namespace RewiewEssensial
{
    public struct Rectangle : IPrintable, IInfo
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public bool IsEmpty { get; set; }

        public string Info { get; set; }


        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }

        public string GetPrintableInfo()
        {
            return $"Width: {Width}, Height: {Height}";
        }

        public string UpdateInfo()
        {
            return $"Rectangle with Width: {Width} and Height: {Height}";
        }
    }
}
