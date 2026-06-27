using ObjectsReview;

namespace Objects
{
    class Sedan(string mark, string model, Color color) 
        : Car(mark, model, color)
    {
        public override void Start()
        {
            Console.WriteLine("The sedan is starting...");
        }

        public override void Stop()
        {
            Console.WriteLine("The sedan is stopping...");
        }
    }
}
