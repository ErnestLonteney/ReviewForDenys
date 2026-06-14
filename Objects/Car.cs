using Objects;

namespace ObjectsReview;

abstract class Car : IInformable 
{
    #region Constructors   

    public Car(string mark, string model, Color color)
    {
        Color = color;
        Mark = mark;
        Model = model;
        Radio = new Radio()
        { 
            Name = $"{mark} {model}"
        };
    }
    #endregion

    #region State

    const uint MaxSpeed = 220; // constant readonly - set only inline

    public required string Vin 
    { 
        get;
        init
        {
            if (value == null || value.Length != 17) 
            {
                throw new ArgumentNullException(nameof(Vin));
            }

            field = value;
        }
    }

    public Radio Radio { get; set; } // auto-property initializer


    public Color Color { get; set; }

    public string Mark { get; }

    public string Model { get; } 

    public string? Number { get; set; }

    public uint CurrentSpeed { get; protected set; }  // read-only (set in constructor/inside class) - field currentSpeed      

    public string? Name => $"{Mark} {Model}";


    // An Example of what stay behind the scenes of a property with a backing field
    // private string color; - field
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

    #endregion

    #region Behavior 

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Car info: Mark - {Mark}, Model - {Model}, Color - {Color}, VinCode - {Vin}, Number - {Number}");
        Console.WriteLine(new string('-',100));
    }
    public abstract void Start();

    public abstract void Stop();

    public void TurnOnRadio()
    {
        Radio.TurnOn();
    }

    public void TurnOffRadios()
    {
        Radio.TurnOff();
    }

    public virtual void Acelerate(uint delta)
    {
        CurrentSpeed += delta;

        if (CurrentSpeed > MaxSpeed)
            CurrentSpeed = MaxSpeed;
    }
    #endregion
}
