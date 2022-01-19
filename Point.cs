using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains.OOP.Lesson6.Task2
{
    internal class Point: Figure
    {
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
