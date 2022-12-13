using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Models
{
    internal class Car:Vehicle
    {
        public Car() { }
        public Car(int cycle)
        {
            this.cycle = cycle;
        }
        public Car(int cycle, string motor) : base(cycle)
        {
            this.motor = motor;
        }
        public Car(int cycle, string motor, double DriveWay) : base(cycle, motor)
        {
            this.DriveWay = DriveWay;
        }
        public Car(int cycle, string motor, double DriveWay, int PassengerCount) : base(cycle, motor, DriveWay)
        {
            this.PassengerCount = PassengerCount;
        }
        public Car(int cycle,
            string motor,
            double DriveWay,
            int PassengerCount,
            double DriveTime) : base(cycle, motor, DriveWay, PassengerCount)
        {
            this.DriveTime = DriveTime;
        }
    }
}
