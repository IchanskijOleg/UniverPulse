using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001ConAppVehicle
{
    class CBatmobile : IMove, IFly, ISwim
    {
        public CBatmobile(CCar car)
        {
            this.car = car;
        }

        protected CCar car;

        public void Fly()
        {
            Console.WriteLine("CBatmobile Літати");
        }

        public void Move()
        {
            Console.WriteLine("CBatmobile Їхати");
        }

        public void Swim()
        {
            Console.WriteLine("CBatmobile Плавати");
        }
    }
}
