using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    class Computer //Parent Class
    {
        public string OperatingSystem { get; set; }
        public int HardDriveSize { get; set; }
        public bool HasTouchScreen { get; set; }

        public Computer (string operatingSystem, int harddriveSize, bool hasTouchScreen)
        {
            OperatingSystem = operatingSystem;
            HardDriveSize = harddriveSize;
            HasTouchScreen = hasTouchScreen;
        }

        public Computer() : this("", 0, false) { }




    }
}
