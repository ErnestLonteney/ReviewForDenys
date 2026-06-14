using ObjectsReview;

namespace Objects
{
    class SportCar(string mark, string model, Color color) 
        : Car(mark, model, color)
    {
        public decimal NitroVolume { get; set; }

        public override void Acelerate(uint value)
        {
            var delta = value;

            if (NitroVolume > 0)
            {
                NitroVolume -= 0.5m;
                delta += 20;
            }

            base.Acelerate(delta);
        }

        public override void Start()
        {
            Console.WriteLine("WROOM!!!");
        }

        public override void Stop()
        {
            Console.WriteLine("STOPPING... whizzzz");
        }
    }
}
