using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class ColorPoint : Point
    {

        public ColorPoint(int x, int y, string color) : base(x, y)
        {
            Color = color;
        }

        private string Color { get; set; }

        public override string ToString()
        {
            return $"{base.ToString() }, { Color}";
        }
    }
}
