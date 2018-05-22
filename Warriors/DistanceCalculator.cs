using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using People;

namespace Warriors
{
    class DistanceCalculator
    {
        public static double DistanceBetweenWarriors(Point point, Point point2)
        {
            double distance = Math.Sqrt((Math.Pow(point2.x - point.x , 2)) + (Math.Pow(point2.y - point.y, 2)));
            return distance;
        }
    }
}
