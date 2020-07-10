using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp212
{
    class Round : RoundShape
    {
        public void GetInfo1()
        {
            Console.WriteLine($"КРУГ:");
            Console.WriteLine($"Координаты: {x},{y} Радиус: {radius}");
            Console.WriteLine($"Площадь: {GetArea(radius)} Длина: {GetLength()}");
            Console.WriteLine();
        }
    }
}
