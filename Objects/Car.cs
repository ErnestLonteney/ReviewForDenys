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

    public virtual string? Name => $"{Mark} {Model}";


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

    public override bool Equals(object? obj)
    {
        if(obj is Car other)
        {
            return Vin == other.Vin;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return Vin.GetHashCode();
    }

    public override string ToString()
    {
        return $"Car {Mark} {Model} on the road";
    }
    public virtual void Start()
    {
        Launch?.Invoke();
    }

    public virtual void Stop()
    {
        Stopped?.Invoke();
    }

    public event Action Launch;
    public event Action Stopped;


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
        {
            throw new DeadEngineException($"Engine died on {CurrentSpeed} speed of the {Mark} {Model}", CurrentSpeed, this);
        }
    }
    #endregion
}
