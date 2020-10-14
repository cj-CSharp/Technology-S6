using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    class Computer : AbstractEntity //Parent Class
    {
        public string OperatingSystem { get; set; }
        public int HardDriveSize { get; set; }
        public readonly bool HasTouchScreen;
        public bool IsOn { get; set; }

        public Computer (string operatingSystem, int harddriveSize, bool hasTouchScreen, bool isOn)
        {
            OperatingSystem = operatingSystem;
            HardDriveSize = harddriveSize;
            HasTouchScreen = hasTouchScreen;
            IsOn = isOn;
        }

        public Computer() : this("", 0, false, false) { }

        public void TurnDeviceOn()
        {
            if(!this.IsOn)
            {
                this.IsOn = true;
            }
        }

        public void TurnDeviceOff()
        {
            if(this.IsOn)
            {
                this.IsOn = false;
            }
        }




    }
}
