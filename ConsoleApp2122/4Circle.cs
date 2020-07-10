using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2122
{
    public class Circle : RoundShape
    {
        public Circle(int X, int Y, int Radius)
        {
            x = X;
            y = Y;
            radius = Radius;
        }
        public string GetInfoAboutCircle()
        {
            return ($"ОКРУЖНОСТЬ: Координаты: {x},{y} Радиус: {radius} Длина: {GetLength()}");
        }
        public string StringEnterCircle()
        {
            return ("Введите параметры (x, y, r):");
        }
    }
}
