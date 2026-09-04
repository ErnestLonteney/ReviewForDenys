using System;
using System.Collections.Generic;
using System.Text;

namespace RewiewEssensial
{
    public class Director(string name, string phone, DateOnly dateOfBirth, string department) : Employee(name, phone, dateOfBirth, [])
    {
        public string Department { get; set; } = string.Empty;

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Department: {Department}");
        }

        public override void SendMessage(string message)
        {
            Console.WriteLine($"Message sent via Email: {message}");
        }   
    }
}
