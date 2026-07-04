using ObjectsReview;

namespace Objects
{
    class Sedan(string mark, string model, Color color) 
        : Car(mark, model, color)
    {
        public override void Start()
        {
            base.Start();
            Console.WriteLine("The sedan is starting...");
        }

        public override void Stop()
        {
            base.Stop();
            Console.WriteLine("The sedan is stopping...");
            Console.ResetColor();
        }
    }
}
