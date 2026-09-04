using System;
using System.Collections.Generic;
using System.Text;

namespace NullableExamples
{
    public class Person(string firstName, string lastName)
    {
        public int Id { get; set; } // 0

        public string FirstName { get; init; } = firstName;

        public string LastName { get; init; } = lastName;

        public string? Email { get; set; } 

    }
}
