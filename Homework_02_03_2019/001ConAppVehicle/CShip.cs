using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001ConAppVehicle
{
    class CShip : CVehicle, IPassenger, ISwim
    {
        public CShip(string name, int x, int y, int price, double speed, SpeedMeasurement speedMeasure, int yearIssue, string port, int countPass)
            : base(name, x, y, price, speed, speedMeasure, yearIssue)
        {
            Port = port;
            countPasseger = countPass;
        }

        private int countPasseger;
        public string Port { get; set; }

        int IPassenger.CountPasseger { get { return countPasseger; } set { value = countPasseger; } }

        public void Swim()
        {
            Console.WriteLine($"Корабель {Name}, може плавати з швидкістю {Speed}{SpeedMeasure}");
        }
    }
}
