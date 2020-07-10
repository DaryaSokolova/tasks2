using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp212
{
    class Line
    {
        public int x1;
        public int y1;
        public int x2;
        public int y2;
        public void GetInfo10()
        {
            Console.WriteLine("Введите параметры: ");
            Console.Write("x1=");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1=");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2=");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2=");
            y2 = Convert.ToInt32(Console.ReadLine());
        }
        public double LengthLine() => Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        public void GetInfo11()
        {
            Console.WriteLine("ЛИНИЯ");
            Console.WriteLine($"Координаты точек линии: ({x1},{y1}) и ({x2},{y2})");
            Console.WriteLine($"Длина: {LengthLine()}");
            Console.WriteLine();
        }
        public void DELETE4()
        {
            x1 = 0;
            x2 = 0;
            y1 = 0;
            y2 = 0;
        }
    }
}
