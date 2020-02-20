using System;
using System.Collections.Generic;
using System.Device.Gpio;
using System.Text;

namespace GpioApi.Logic
{
    public interface IPinLogic
    {
        void OpenPin(int pinNumber);

        void ClosePin(int pinNumber);

        void SetPinMode(int pinNumber, PinMode pinMode);
    }
}
