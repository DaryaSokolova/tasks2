using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp212
{
    class Circle : RoundShape
    {
        public void GetInfo3()
        {
            Console.WriteLine("ОКРУЖНОСТЬ");
            Console.WriteLine($"Координаты: {x},{y} Радиус: {radius}");
            Console.WriteLine($"Длина: {GetLength()}");
            Console.WriteLine();
        }
    }
}
