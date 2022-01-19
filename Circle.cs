using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains.OOP.Lesson6.Task2
{
    internal sealed class Circle : Point
    {
        internal double CircleArea(double Radius)
        {
            return 3.14 * Radius * Radius;
        }

        internal override string HorizontalMovement()
        {
            return base.HorizontalMovement();

        }

        internal override string VerticalMovement()
        {
            return base.VerticalMovement();
        }




    }
}
