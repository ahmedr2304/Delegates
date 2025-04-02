using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class RectangleHelper
    {
        public void GetArea(decimal width, decimal height) => Console.WriteLine($"Area : {width} * {height} = {width * height}");
        public void GetPerimeter(decimal width, decimal height) => Console.WriteLine($"Perimeter : 2 * ({width} + {height}) = { 2 * (width + height) }");

    }
}
