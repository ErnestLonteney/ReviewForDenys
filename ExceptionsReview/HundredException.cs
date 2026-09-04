using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsReview
{
    public class HundredException : Exception
    {
        public HundredException() 
            : base("a cannot be 100")
        {
        }

        public HundredException(Exception innerException) : base("a cannot be 100", innerException)
        {
                
        }

        public int Staus { get; set; } 
    }
}
