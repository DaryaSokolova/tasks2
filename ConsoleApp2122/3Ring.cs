using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2122
{
    public class Ring : RoundShape
    {
        public Ring(int X, int Y, int Radius, int InnerRadius)
        {
            x = X;
            y = Y;
            radius = Radius;
            innerRadius = InnerRadius;
        }
        public string GetInfoAboutRing()
        {
            return ($"КОЛЬЦО: Координаты: {x},{y} Радиус: {radius} Внутренний радиус: {innerRadius} Площадь: {GetArea()} Длина: {GetLength()}");
        }
        public string StringEnterRing()
        {
            return ("Введите параметры (x, y, r, r'):");
        }
    }
}
