using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }
        public int Wheels { get; set; }
        public bool HadAccident {get; set;}
        public int Owners { get; set; }

        public Car(string brand, string model, int year, string make, string color, int wheels, bool hadaccident, int owners)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Make = make;
            Color = color;
            Wheels = wheels;
            HadAccident = hadaccident;
            Owners = owners;
        }

        public Car()
        {
        }
    }

}
