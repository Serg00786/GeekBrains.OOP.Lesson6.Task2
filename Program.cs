using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains.OOP.Lesson6.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            Circle circ = new Circle();
            Figure fig = new Figure();
            fig.ChangeFigureColor("yellow");
            fig.ChangeVisibility(true);
            string a=rect.VerticalMovement();
            string b = circ.HorizontalMovement();
            Console.ReadLine();
        }
    }
}
