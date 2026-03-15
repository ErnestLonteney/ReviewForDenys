using ObjectsReview;

namespace Objects
{
    class SportCar : Car
    {
        public SportCar(string mark, string model, string vinCode, int number) 
            : base(mark, model, vinCode, number)
        {
        }
        public decimal NitroVolume { get; set; }

        public string ManageBox { get; set; }

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
    }
}
