﻿using System;
using System.Device.Gpio;
using System.Threading;

namespace blinky
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Blinking LED. Press Ctrl+C to end.");
            int pin = 18;
            using var controller = new GpioController();
            controller.OpenPin(pin, PinMode.Output);
            bool ledOn = true;
            while (true)
            {
                controller.Write(pin, ((ledOn) ? PinValue.High : PinValue.Low));
                Thread.Sleep(250);
                ledOn = !ledOn;
            }
        }
    }
}