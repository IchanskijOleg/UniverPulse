using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001ConAppVehicle
{
    class CAmphibian : CVehicle, IMove, ISwim
    {
        public CAmphibian(CVehicle vehicle)
            : base(vehicle.Name, vehicle.Point.X, vehicle.Point.Y, vehicle.Price, vehicle.Speed, vehicle.SpeedMeasure, vehicle.YearIssue)
        {
        } 

        public void Move()
        {
            Console.WriteLine($"Амфібія зроблена з {Name}, може їздити до швидкості {Speed}{SpeedMeasure}");
        }

        public void Swim()
        {
            Console.WriteLine($"Амфібія зроблена з {Name}, може плавати до швидкості {Speed}{SpeedMeasure}");
        }
    }
}
