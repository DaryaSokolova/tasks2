using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp212
{
    public abstract class RectangularArea
    {
        private protected int a;
        public int A
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Длина не может быть меньше 0, фигура создана с ошибкой");
                }
                else
                {
                    a = value;
                }
            }
            get { return a; }
        }
        private protected int b;
        public int B
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Длина не может быть меньше 0, фигура создана с ошибкой");
                }
                else
                {
                    b = value;
                }
            }
            get { return b; }
        }
        public int Perimeter(int a, int b) => a + a + b + b;
        public int Square(int a, int b) => a * b;
        public void DELETE2()
        {
            a = 0;
            b = 0;
        }
    }
}
