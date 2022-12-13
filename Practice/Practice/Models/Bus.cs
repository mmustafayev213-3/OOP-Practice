using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Models
{
    internal class Bus:Vehicle
    {
        public Bus()
        {

        }
        public Bus(int cycle) 
        {
            this.cycle = cycle;
        }
        public Bus(int cycle, string motor) : base(cycle)
        {
            this.motor = motor;
        }
        public Bus(int cycle, string motor, double DriveWay) : base(cycle, motor)
        {
            this.DriveWay = DriveWay;
        }
        public Bus(int cycle, string motor, double DriveWay, int PassengerCount) : base(cycle, motor, DriveWay)
        {
            this.PassengerCount = PassengerCount;
        }
        public Bus(int cycle,
            string motor,
            double DriveWay,
            int PassengerCount,
            double DriveTime) : base(cycle, motor, DriveWay, PassengerCount)
        {
            this.DriveTime = DriveTime;
        }
    }
}
