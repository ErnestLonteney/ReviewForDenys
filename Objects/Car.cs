using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsReview
{
    class Car
    {
        private string color; // red

        public string Color
        {
            get 
            {
                return color.ToUpper(); 
            }
            set 
            {
                if (value != "Black")
                    color = value;
                else
                {
                    color = "Not defined";
                }
            }
        }

        //public void SetColor(string value)
        //{
        //    if (value != "Black")
        //        color = value;
        //    else
        //    {
        //        color = "Not defined";
        //    }

        //}

        //public string GetColor() 
        //{ 
        //    return color; 
        //}


        // private string mark;

        //public string Mark
        //{
        //    get 
        //    { 
        //        return mark; 
        //    }
        //    set 
        //    {
        //        mark = value;    
        //    }
        //}

        public string Mark { get; }

        private string model;
        private float engeeneVolume;
      

        public uint CurrentSpeed { get; private set; }
            

        const uint MaxSpeed = 220;

        public void Start() 
        {
            Console.WriteLine("Car has been started");
        }


        public void Stop()
        {
            Console.WriteLine("Car has stopped");
        }


        public void Acelerate(uint delta)
        {
            CurrentSpeed += delta;

            if (CurrentSpeed > MaxSpeed)
                CurrentSpeed = MaxSpeed;
        }
    }
}
