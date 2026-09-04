using System;
using System.Collections.Generic;
using System.Text;

namespace RewiewEssensial
{
    public static class Calculator
    {
        static Calculator()
        {
            LicenseKey = string.Empty; // get date for this member from some source;
        }

        public static string LicenseKey { get; set; } 

        //  public string OperatorName { get; set; }

        //public Calculator(string operatorName)
        //{
        //   // OperatorName = operatorName;
        //}

        public static void Add(double a, double b)
        {
            Console.WriteLine($"The sum of {a} and {b} is: {a + b}");
        }

        public static void Subtract(double a, double b)
        {
            Console.WriteLine($"The difference between {a} and {b} is: {a - b}");
        }
        

        public static string GetInfo()
        {
            return $"Arithmetic calculator. License Key: {LicenseKey}";
        }
    }
}
