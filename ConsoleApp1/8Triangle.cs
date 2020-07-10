using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp212
{
    class Triangle
    {
        private protected int a1;
        public int A1
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Длина не может быть меньше 0, фигура создана с ошибкой");
                }
                else
                {
                    a1 = value;
                }
            }
            get { return a1; }
        }
        private protected int a2;
        public int A2
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Длина не может быть меньше 0, фигура создана с ошибкой");
                }
                else
                {
                    a2 = value;
                }
            }
            get { return a2; }
        }
        private protected int a3;
        public int A3
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Длина не может быть меньше 0, фигура создана с ошибкой");
                }
                else
                {
                    if ((a1 + a2 < a3) || (a2 + a3 < a1) || (a1 + a3 < a2))
                    {
                        a1 = 0;
                        a2 = 0;
                        Console.WriteLine("Такого треугольника не существует. Фигура создана неверно");
                    }
                    else
                    {
                        a3 = value;
                    }
                }
            }
            get { return a3; }
        }

        public void GetInfo8()
        {
            Console.WriteLine("Введите параметры: ");
            Console.Write("a1=");
            A1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("a2=");
            A2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("a3=");
            A3 = Convert.ToInt32(Console.ReadLine());
        }
        public int P() => a1 + a2 + a3;
        public double Square() => Math.Sqrt(P() / 2 * (P() / 2 - a1) * (P() / 2 - a2) * (P() / 2 - a3));
        public void GetInfo9()
        {
            Console.WriteLine("ТРЕУГОЛЬНИК");
            Console.WriteLine($"Строны: {a1}, {a2}, {a3}");
            Console.WriteLine($"Периметр: {P()}");
            Console.WriteLine($"Площадь: {Square()}");
            Console.WriteLine();
        }
        public void DELETE3()
        {
            a1 = 0;
            a2 = 0;
            a3 = 0;
        }
    }
}
