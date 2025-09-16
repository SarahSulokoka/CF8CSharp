using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class AbstractPoint : IMoveable

    {
        public  int X { get; set; }
        public virtual void Move5()
        {
            X += 5;
        }
        public virtual void Move6() {
            X += 6;
        }
}
