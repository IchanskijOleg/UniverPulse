using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001ConAppVehicle
{
    class CAmphibian : IMove, ISwim
    {
        public CAmphibian(CVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        CVehicle vehicle;

        public void Move()
        {
            Console.WriteLine("CAmphibian Їхати");
        }

        public void Swim()
        {
            Console.WriteLine("CAmphibian Плавати");
        }
    }
}
