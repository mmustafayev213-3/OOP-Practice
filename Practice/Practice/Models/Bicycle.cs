using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Models
{
    internal class Bicycle:Vehicle
    {
        public Bicycle()
        {

        }
        public Bicycle(int cycle)
        {
            this.cycle = cycle;
        }
        public Bicycle(int cycle, string motor) : base(cycle)
        {
            this.motor = motor;
        }
        public Bicycle(int cycle, string motor, double DriveWay) : base(cycle, motor)
        {
            this.DriveWay = DriveWay;
        }
        public Bicycle(int cycle, string motor, double DriveWay, int PassengerCount) : base(cycle, motor, DriveWay)
        {
            this.PassengerCount = PassengerCount;
        }
        public Bicycle(int cycle,
            string motor,
            double DriveWay,
            int PassengerCount,
            double DriveTime) : base(cycle, motor, DriveWay, PassengerCount)
        {
            this.DriveTime = DriveTime;
        }
    }
}
