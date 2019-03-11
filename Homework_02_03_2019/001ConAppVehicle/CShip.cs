using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001ConAppVehicle
{
    class CShip : CVehicle, IPassenger
    {
        public CShip(int x, int y, int price, int speed, int yearIssue, string port, int countPass) : base(x, y, price, speed, yearIssue)
        {
            Port = port;
            countPasseger = countPass;
        }

        private int countPasseger;
        public string Port { get; set; }
        int IPassenger.CountPasseger { get { return countPasseger; } set { value = countPasseger; } }
    }
}
