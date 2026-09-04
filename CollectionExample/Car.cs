using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionExample
{
    internal class Car
    {
        public required string Mark { get; init; }
        public required string Make { get; init; }

        public required DateOnly IssueDate { get; init; }

        public required string VIN { get; init; }

        public string? Color { get; set; }

    }
}
