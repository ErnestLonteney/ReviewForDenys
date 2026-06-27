using ObjectsReview;
using System;
using System.Collections.Generic;
using System.Text;

namespace Objects
{
    class DeadEngineException : Exception
    {
        public DeadEngineException() { }

        public DeadEngineException(string message)
            : base(message)
        {
        }

        public DeadEngineException(string message, uint speed, Car car) 
            : base(message)
        {
            Speed = speed;
            Car = car;
        }

        public uint Speed { get; init; }
        public Car Car { get; init; }
    }
}
