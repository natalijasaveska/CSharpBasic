using System;
using System.Collections.Generic;
using System.Text;

namespace Class5_Task1
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public int CalculateSpeed()
        {
            return Speed * Driver.GetASkill();
        }

        public Car(string model, Driver driver, int speed)
        {
            Model = model;
            Driver = driver;
            Speed = speed;

        }
    }
}
