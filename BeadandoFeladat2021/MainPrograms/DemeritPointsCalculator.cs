using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeadandoFeladat2021.MainPrograms
{
    public class DemeritPointsCalculator
    {
        private const int SpeedLimit = 50;
        private const int MaxSpeed = 180;

        public int CalculateDemeritPoints(int speed)
        {
            if (speed < 0 || speed > MaxSpeed)
                throw new ArgumentOutOfRangeException("speed");

            if (speed <= SpeedLimit) return 0;

            const int kmPerDemeritPoint = 10;
            var demeritPoints = (speed - SpeedLimit) / kmPerDemeritPoint;

            return demeritPoints;
        }
    }
}
