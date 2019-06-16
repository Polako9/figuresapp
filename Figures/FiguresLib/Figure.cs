using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    abstract public class Figure
    {
       
        public override string ToString() => $"Figure: {Label}";
        public string Label { get; set; }

        public System.Drawing.Color Color { get; set; }

        private static int counter = 0;
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
