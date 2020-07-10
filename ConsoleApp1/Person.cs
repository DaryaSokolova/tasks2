using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp212
{
    class Person
    {
        public string NAME;
        public void conclusion1()
        {
            Console.WriteLine($"{NAME}, выберите действие: ");
            Console.WriteLine("1 - Добавить фигуру");
            Console.WriteLine("2 - Вывести фигуры");
            Console.WriteLine("3 - Очистить холст");
            Console.WriteLine("4 - Сменить пользователя");
            Console.WriteLine("Иные цифры - Выход");
        }
        public void conclusion2()
        {
            Console.WriteLine($"{NAME}, выберите тип фигуры: ");
            Console.WriteLine("1 - Круг");
            Console.WriteLine("2 - Кольцо");
            Console.WriteLine("3 - Окружность");
            Console.WriteLine("4 - Прямоугольник ");
            Console.WriteLine("5 - Квадрат");
            Console.WriteLine("6 - Треугольник");
            Console.WriteLine("7 - Линия");
            Console.WriteLine("Иные цифры - Назад");
        }
    }
}
