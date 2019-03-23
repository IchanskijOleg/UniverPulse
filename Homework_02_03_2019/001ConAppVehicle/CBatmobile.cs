using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001ConAppVehicle
{
    class CBatmobile : CVehicle, IMove, IFly, ISwim
    {
        public CBatmobile(CVehicle vehicle)
            : base(vehicle.Name, vehicle.Point.X, vehicle.Point.Y, vehicle.Price, vehicle.Speed, vehicle.SpeedMeasure, vehicle.YearIssue)
        {

        }

        public void Fly()
        {
            Console.WriteLine($"Бетмобіль зроблений з {Name}, може літати з швидкістю {Speed}{SpeedMeasure}");
        }

        public void Move()
        {
            Console.WriteLine($"Бетмобіль зроблений з {Name}, може їздити з швидкістю {Speed}{SpeedMeasure}");
        }

        public void Swim()
        {
            Console.WriteLine($"Бетмобіль зроблений з {Name}, може плавати з швидкістю {Speed}{SpeedMeasure}");
        }
    }
}
