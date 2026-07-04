using ObjectsReview;

namespace Objects;

class Crossower(string mark, string model, Color color)
    : Car(mark, model, color)
{
    public override void Start()
    {
        base.Start();
        Console.WriteLine("The crossower is starting...");
    }

    public override void Stop()
    {
        base.Stop();
        Console.WriteLine("The crossower is stopping...");
        Console.ResetColor();
    }
}
