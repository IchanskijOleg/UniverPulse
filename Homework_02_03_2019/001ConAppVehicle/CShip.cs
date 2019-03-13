using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001ConAppVehicle
{
    class CShip : CVehicle, IPassenger
    {
        public CShip(string name, int x, int y, int price, double speed, SpeedMeasurement speedMeasure, int yearIssue, string port, int countPass) : base(name, x, y, price, speed, speedMeasure, yearIssue)
        {
            Port = port;
            countPasseger = countPass;
            this.speed = speed;
        }
        private double speed;
        private int countPasseger;
        public string Port { get; set; }
        public override double Speed
        {
            get { return speed * 1.852; }
            set { speed = value / 1.852; }
        }
        int IPassenger.CountPasseger { get { return countPasseger; } set { value = countPasseger; } }
    }
}
