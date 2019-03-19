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
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }
}
