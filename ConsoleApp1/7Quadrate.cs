using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp212
{
    class Quadrate : RectangularArea
    {
        public void GetInfo6()
        {
            Console.WriteLine("Введите параметры: ");
            Console.Write("a=");
            A = Convert.ToInt32(Console.ReadLine());
        }
        public void GetInfo7()
        {
            Console.WriteLine("КВАДРАТ");
            Console.WriteLine($"Строна: {a}");
            Console.WriteLine($"Периметр: {Perimeter(a, a)}");
            Console.WriteLine($"Площадь: {Square(a, a)}");
            Console.WriteLine();
        }
    }
}
