using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains.OOP.Lesson6.Task2
{
    internal class Figure
    {
        private string FigureColor;
        private bool IsVisible;

        internal virtual string HorizontalMovement()
        {
            string Res = "Figure Moved Horizontally";
            Console.WriteLine(Res);
            return Res;
        }

        internal virtual string VerticalMovement()
        {

            string Res= "Figure Moved Vertically";
            Console.WriteLine(Res);
            return Res;
        }

        internal string ChangeFigureColor(string newcolor)
        {
            FigureColor = newcolor;
            Console.WriteLine("new color is "+FigureColor);
            return FigureColor;
        }

        internal bool ChangeVisibility(bool NewIsVisible)
        {
            IsVisible = NewIsVisible;
            Console.WriteLine("New Visibility is "+ IsVisible);
            return IsVisible;
        }
    }
}
