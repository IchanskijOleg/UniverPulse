using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001ConAppVehicle
{
    abstract class CVehicle
    {
        public CVehicle(string name, int x, int y, int price, int speed, int yearIssue)
        {
            Name = name;
            Point = new Coordinates(x, y);
            Price = price;
            Speed = speed;
            YearIssue = yearIssue;
        }
        public string Name { get; }
        public int Price { get; set; }
        public int Speed { get; set; }
        public int YearIssue { get; set; }

        public Coordinates Point { get; set; }

        public override string ToString()
        {
            return $"{Point.X},{Point.Y}"; //String.Format()
        }
    }
}
