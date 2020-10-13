using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    class SmartPhone : Computer //child class
    {
        public double ScreenSizeInches { get; }

        public SmartPhone (string operatingSystem, int harddriveSize, bool hasTouchScreen, bool isOn, double screenSizeInches) : base(operatingSystem, harddriveSize, hasTouchScreen, isOn)
        {
            ScreenSizeInches = screenSizeInches;
        }

        public double ScreenSizeInCM ()
        {
            return ScreenSizeInches * 2.54;
        }
    }
}
