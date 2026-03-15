using Objects;
using System.Collections;

namespace ObjectsReview
{
    class Car(string mark, string model, string vinCode, int number) 
    {
        #region Constructors
        public Radio Radio { get; set; } = new Radio(); // auto-property initializer

        public Car(string mark, string model, string color, string vinCode, int number)
            : this(mark, model, vinCode, number)
        {
            Color = color;
        }
        #endregion

        #region State

        private int counter; // inner field 
        private float engeeneVolume = 1.6f; // inner field

        const uint MaxSpeed = 220; // constant readonly - set only inline

        public required string Color //  required - Must be put per creating into initializer block -  field color
        {
            get 
            {
                if (field != null)
                    return field.ToUpper();

                return string.Empty;
            }
            init // only one time in initializer block
            {
                if (value != "Black")
                    field = value;
                else
                {
                    field = "Not defined";
                }
            }
        }

        // private string color;
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

        public string Mark { get; } = mark;

        public string Model { get; } = model;

        public string VinCode { get; } = vinCode;

        public int Number { get; } = number;

        public uint CurrentSpeed { get; protected set; }  // read-only (set in constructor/inside class) - field currentSpeed      

        
        #endregion

        #region Behavior 

        public void PrintInfo()
        {
            Console.WriteLine($"Car info: Mark - {Mark}, Model - {Model}, Color - {Color}, VinCode - {VinCode}, Number - {Number}");
            Console.WriteLine(new string('-',100));
        }
        public void Start() 
        {
            Console.WriteLine("Car has been started");
        }

        public void Stop()
        {
            Console.WriteLine("Car has stopped");
        }

        public virtual void Acelerate(uint delta)
        {
            CurrentSpeed += delta;

            if (CurrentSpeed > MaxSpeed)
                CurrentSpeed = MaxSpeed;
        }
        #endregion
    }
}
