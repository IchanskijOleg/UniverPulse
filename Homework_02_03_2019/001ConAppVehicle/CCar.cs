﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001ConAppVehicle
{
    class CCar : CVehicle, IMove
    {
        public CCar(string name, int x, int y, int price, double speed, SpeedMeasurement speedMeasure, int yearIssue) 
            : base(name, x, y, price, speed, speedMeasure, yearIssue)
        {
        }

        public void Move()
        {
            Console.WriteLine($"Автомобіль {Name}, може їздити з швидкістю {Speed}{SpeedMeasure}");
        }
    }
}
