using System;
using System.Collections.Generic;
using System.Device.Gpio;
using System.Text;

namespace GpioApi.Logic
{
    public class PinLogic : IPinLogic
    {
        public GpioController controller = new GpioController(PinNumberingScheme.Logical);

        public void OpenPin(int pinNumber) => controller.OpenPin(pinNumber, PinMode.Output);

        public void ClosePin(int pinNumber) => controller.ClosePin(pinNumber);

        public void SetPinMode(int pinNumber, PinMode pinMode) => controller.SetPinMode(pinNumber, pinMode);
    }
}
