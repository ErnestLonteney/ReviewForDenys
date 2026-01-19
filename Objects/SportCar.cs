using ObjectsReview;

namespace Objects
{
    class SportCar : Car
    {
        public SportCar()
            :base("Fiat", "Ferrari")
        {           
        }

        public SportCar(string mark, string model, string color)
            : base(mark, model, color)
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
