using ObjectsReview;

namespace Objects;

class Crossower(string mark, string model, Color color)
    : Car(mark, model, color)
{
    public override void Start()
    {
        Console.WriteLine("HRRRRR BRRRR");
    }

    public override void Stop()
    {
        Console.WriteLine("STOPPING... shhhh BRRRR");
    }
}
