﻿using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Panasonic");
            myRadio.SwitchOn();
            myRadio.ListenRadio();

            TV myTv = new TV(false, "Samsung");
            myTv.SwitchOn();
            myTv.WatchTV();
        }
    }
}
