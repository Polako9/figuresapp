using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing

namespace FiguresLib
{
    public class Class1
    {
        namespace FiguresLib
    {

        public const int FRACTIONAL_DIGITS = 4;

        public class Point
        {
            // fields
            public readonly double X, Y; //immutability

            // constructor
            public Point(double x = 0.0, double y = 0.0)
            {
                X = Math.Round(x, Figure.FRACTIONAL_DIGITS);
                Y = Math.Round(y, Figure.FRACTIONAL_DIGITS);
                Color = Color.Blue;
            }
        }
        public class Point : Figure

            public override void Draw()
        {
            Console.WriteLine("drawing: " + $"Point({X}, {Y}), {Color}");
        }
        abstract public class Figure
        {
            public string Label { get; set; }
            private static int counter = 0;
            public System.Drawing.Color Color { get; set; }

            // constructor
            public Figure()
            {
                counter++;
                this.Color = Color.Black;
                Label = $"{GetType().Name} #{counter}";
            }

            abstract public void Draw();

            public override string ToString() => $"Figure: {Label}";
        }
    }
}
}
