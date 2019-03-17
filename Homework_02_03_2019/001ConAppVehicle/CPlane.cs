using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001ConAppVehicle
{
    class CPlane : CVehicle, IPassenger
    {
        public CPlane(string name, int x, int y, int price, int speed, SpeedMeasurement speedMeasure, int yearIssue, int height, int countPass)
            : base(name, x, y, price, speed, speedMeasure, yearIssue)
        {
            Height = height;
            CountPasseger = countPass;
        }

        public int CountPasseger { get; set; }
        public int Height { get; set; }
    }
}
