using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001ConAppVehicle
{
    class CPlane : CVehicle, IPassenger
    {
        public CPlane(string name, int x, int y, int price, int speed, int yearIssue, int height, int countPass) : base(name, x, y, price, speed, countPass)
        {
            Height = height;
            countPasseger = countPass;
        }

        private int countPasseger;
        public int Height { get; set; }
        int IPassenger.CountPasseger { get { return countPasseger; } set { value = countPasseger; } }
    }
}
