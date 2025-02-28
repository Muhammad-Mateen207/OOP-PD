using PD_04_Task1_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pd01
{
    internal class Ship
    {
        public string shipnumber;
        public Angle shiplocation1;
        public Angle shiplocation2;
        public Ship(string shipnumber, int degree, float minutes, char direction, int degree1, float minutes1, char direction1)
        {
            this.shipnumber = shipnumber;
            shiplocation1 = new Angle(degree, minutes, direction);
            shiplocation2 = new Angle(degree1, minutes1, direction);
        }

        public Ship(int degree, float minutes, char direction, int degree1, float minutes1, char direction1)
        {
            shiplocation1 = new Angle(degree, minutes, direction);
            shiplocation2 = new Angle(degree1, minutes1, direction);
        }
    }
}
