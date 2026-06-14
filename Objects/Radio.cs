namespace Objects;

internal class Radio
{
    public required string Name { get; init; }

    public int Freaquency { get; set; }

    public void TurnOn()
    {
        Console.WriteLine($"Radio {Name} is turned on");
    }

    public void TurnOff()
    {
        Console.WriteLine($"Radio {Name} is turned off");
    }   
}
