using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp212
{
    class Ring : RoundShape
    {
        public double GetAreaRing() => GetArea(radius) - GetArea(innerRadius);
        public double GetWidth() => radius - innerRadius;
        public void GetInfo2()
        {
            Console.WriteLine($"КОЛЬЦО:");
            Console.WriteLine($"Координаты: {x},{y} Радиус: {radius} Внутренний радиус: {innerRadius}");
            Console.WriteLine($"Площадь: {GetAreaRing()}");
            Console.WriteLine($"Ширина: {GetWidth()}");
            Console.WriteLine();
        }
    }
}
