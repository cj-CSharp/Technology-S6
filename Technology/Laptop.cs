using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    class Laptop : Computer //child class
    {
        public double Weight { get; }

        public Laptop(string operatingSystem, int harddriveSize, bool hasTouchScreen, bool isOn, double weight) : base(operatingSystem, harddriveSize, hasTouchScreen, isOn)
        {
            Weight = weight;
        }

        public bool IsHeavy()
        {
            if(Weight > 6)
            {
                return true;
            }
            return false;
        }
    }
}
