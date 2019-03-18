using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001ConAppVehicle
{
    class CompareByPrice : IComparer<CVehicle>
    {
        public int Compare(CVehicle x, CVehicle y)
        {
            return (int)(x.Price - y.Price);
        }
    }
}
