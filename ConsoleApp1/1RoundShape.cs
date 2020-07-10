using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp212
{
    public abstract class RoundShape
    {
        public int x;
        public int y;
        private protected int radius;
        public int Radius
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Радиус не может быть меньше 0, фигура создана с ошибкой");
                }
                else
                {
                    radius = value;
                }
            }
            get { return radius; }
        }
        private protected int innerRadius;
        public int InnerRadius
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Радиус не может быть меньше 0, фигура создана с ошибкой");
                }
                else
                {
                    innerRadius = value;
                }
            }
            get { return innerRadius; }
        }
        public void GetInfo(int a)
        {
            Console.WriteLine("Введите параметры: ");
            Console.Write("x=");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y=");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("r=");
            Radius = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                Console.Write("r'=");
                InnerRadius = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(radius);
        }
        public double GetLength() => 2 * Math.PI * radius;
        public double GetArea(int R) => Math.PI * R * R;
        public void DELETE1()
        {
            x = 0;
            y = 0;
            radius = 0;
            innerRadius = 0;
        }
    }
}
