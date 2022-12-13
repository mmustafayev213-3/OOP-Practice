using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Models
{
    internal class Vehicle
    {
        public int cycle;
        public string motor;
        public double DriveWay;
        public int PassengerCount;
        public double DriveTime;

        public Vehicle()
        {

        }
        public Vehicle(int cycle)
        {
            this.cycle = cycle;
        }
        public Vehicle(int cycle,string motor):this(cycle)
        {
            this.motor= motor;
        }
        public Vehicle(int cycle, string motor,double DriveWay):this(cycle,motor)
        {
            this.DriveWay= DriveWay;    
        }
        public Vehicle(int cycle, string motor, double DriveWay,int PassengerCount):this(cycle,motor,DriveWay)
        {
            this.PassengerCount= PassengerCount;
        }
        public Vehicle(int cycle, 
            string motor, 
            double DriveWay,
            int PassengerCount,
            double DriveTime):this(cycle,motor,DriveWay,PassengerCount)
        {
            this.DriveTime= DriveTime;
        }
        public  void ShowInfo()
        {
            Console.WriteLine($"Neqliyyat Vasitesinin dovru carxi:{cycle}," +
                $" Motor:{motor}," +
                $" Getdiyi Yol:{DriveWay}"+
                $" Sernisin Sayi:{PassengerCount}," +
                $" Getdiyi Zaman:{DriveTime}");
        }
        public  void GetSpeed()
        {
            double speed = DriveWay / DriveTime;
            Console.WriteLine($" Getdiyi Yol:{DriveWay} ve Getdiyi Zaman {DriveTime} gore   Getdiyi Suret :{speed} km/saat-dir");
        }
    }
}
