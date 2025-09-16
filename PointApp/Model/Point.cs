using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointApp.Model
{
    internal class Point
    {
        public int X { get; set; }

        public override string? ToString()
        {
            return $"{X}";
        }

        public void Move5()
        {
            X += 5;
        }

    

        public override void Move5()
        {
            base.Move5(); // Call the base class method to move X by 5
            Y += 5;
        }
    }
}
