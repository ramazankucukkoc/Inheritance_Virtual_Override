using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   // Bir abstract (soyut) sınıf oluşturuyorsak sınıf
   // içerisinde muhakkak bir abstract metot, eğer bir
   // abstract metot tanımlıyorsak muhakkak sınıf yapısının da abstract class olması gerekmektedir.
    abstract class BaseClass
    {
        protected int _x = 100;
        protected int _y = 150;

        public abstract void AbstractMethod();
        public abstract int X { get; }
        public abstract int Y { get; }
    }
}
