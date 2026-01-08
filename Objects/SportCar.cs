using ObjectsReview;
using System;
using System.Collections.Generic;
using System.Text;

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

        public void AccelerateWithNitro(int value)
        {
            if (NitroVolume > 0)
            {
                NitroVolume -= 0.5m;
                Acelerate((uint)(value + 20));
            }
            else
            {
                Acelerate((uint)value);
            }
        }

    }
}
