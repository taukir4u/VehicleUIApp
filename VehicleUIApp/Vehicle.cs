using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleUIApp
{
    class Vehicle
    {
        public string VehicleName { get; private set; }
        public string RegNo { get; private set; }

        public List<double> speedList = new List<double>();

        public Vehicle(string vehicleName, string regNo)
        {
            VehicleName = vehicleName;
            RegNo = regNo;
        }

        public string EnterSpeed(double speed)
        {
            speedList.Add(speed);
            return "Speed Entered";
        }

        public double GetMinSpeed()
        {
            List<double> minList = speedList;

            minList.Sort();

            return Convert.ToDouble(minList[0]);
        }

        public double GetMaxSpeed()
        {
            List<double> maxList = speedList;

            maxList.Sort();

            maxList.Reverse();

            return Convert.ToDouble(maxList[0]);
        }

        public double GetAverage()
        {
            double total = 0;
            foreach (double aSpeed in speedList)
            {
                total += aSpeed;
            }
            return Math.Round(total / speedList.Count);
        }
    }
}
