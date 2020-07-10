using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp212
{
    class Rectangle : RectangularArea
    {
        public void GetInfo4()
        {
            Console.WriteLine("Введите параметры: ");
            Console.Write("a=");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            B = Convert.ToInt32(Console.ReadLine());
        }
        public void GetInfo5()
        {
            Console.WriteLine("ПРЯМОУГОЛЬНИК");
            Console.WriteLine($"Длины: {a} и {b}");
            Console.WriteLine($"Периметр: {Perimeter(a, b)}");
            Console.WriteLine($"Площадь: {Square(a, b)}");
            Console.WriteLine();
        }
    }
}
