using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class DerivedClass : BaseClass
    {
        public override int X { get { return _x + 10; } }
        public override int Y { get { return _y + 20; } }

        public override void AbstractMethod()
        {
            _x++;
            _y--;

        }
    }
}
