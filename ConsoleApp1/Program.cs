using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp212
{
    class Program
    {
        static void Main(string[] args)
        {
        bool fl = true;
        bool fl1 = true;

        int argRound = -1;
        int argRing = -1;
        int argCircle = -1;
        int argRectangle = -1;
        int argQuadrate = -1;
        int argTriangle = -1;
        int argLine = -1;

        Round round = new Round();
        Ring ring = new Ring();
        Circle circle = new Circle();
        Rectangle rectangle = new Rectangle();
        Quadrate quadrate = new Quadrate();
        Triangle triangle = new Triangle();
        Line line = new Line();
        Person person = new Person();

        Console.WriteLine("Введите имя пользователя: ");
            person.NAME = Console.ReadLine();

            while (fl == true)
            {
                person.conclusion1();
                int selection = Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        fl1 = true;
                        while (fl1 == true)
                        {
                            person.conclusion2();

                            int selection1 = Convert.ToInt32(Console.ReadLine());
                            switch (selection1)
                            {
                                case 1:
                                    Console.WriteLine("Создание - Круг");
                                    round.GetInfo(-1);
                                    Console.WriteLine("Фигура создана!");
                                    argRound = 0;
                                    break;
                                case 2:
                                    Console.WriteLine("Создание - Кольцо");
                                    ring.GetInfo(0);
                                    Console.WriteLine("Фигура создана!");
                                    argRing = 0;
                                    break;
                                case 3:
                                    Console.WriteLine("Создание - Окружность");
                                    circle.GetInfo(-1);
                                    Console.WriteLine("Фигура создана!");
                                    argCircle = 0;
                                    break;
                                case 4:
                                    Console.WriteLine("Создание - Прямоугольник");
                                    rectangle.GetInfo4();
                                    Console.WriteLine("Фигура создана!");
                                    argRectangle = 0;
                                    break;
                                case 5:
                                    Console.WriteLine("Создание - Квадрат");
                                    quadrate.GetInfo6();
                                    Console.WriteLine("Фигура создана!");
                                    argQuadrate = 0;
                                    break;
                                case 6:
                                    Console.WriteLine("Создание - Треугольник");
                                    triangle.GetInfo8();
                                    Console.WriteLine("Фигура создана!");
                                    argTriangle = 0;
                                    break;
                                case 7:
                                    Console.WriteLine("Создание - Линия");
                                    line.GetInfo10();
                                    Console.WriteLine("Фигура создана!");
                                    argLine = 0;
                                    break;
                                default:
                                    Console.WriteLine("Вы вернулись к предыдущему выбору.");
                                    fl1 = false;
                                    break;
                            }
}
                        break;
                    case 2:
                        Console.WriteLine("Фигуры: ");
                        if (argRound == 0) round.GetInfo1();
                        if (argRing == 0) ring.GetInfo2();
                        if (argCircle == 0) circle.GetInfo3();
                        if (argRectangle == 0) rectangle.GetInfo5();
                        if (argQuadrate == 0) quadrate.GetInfo7();
                        if (argTriangle == 0) triangle.GetInfo9();
                        if (argLine == 0) line.GetInfo11();
                        break;
                    case 3:
                        Console.WriteLine("Фигуры удалены!");
                        round.DELETE1();
                        argRound = -1;
                        ring.DELETE1();
                        argRing = -1;
                        circle.DELETE1();
                        argCircle = -1;
                        rectangle.DELETE2();
                        argRectangle = -1;
                        quadrate.DELETE2();
                        argQuadrate = -1;
                        triangle.DELETE3();
                        argTriangle = -1;
                        line.DELETE4();
                        argLine = -1;
                        break;
                    case 4:
                        Console.WriteLine("Введите имя пользователя: ");
                        person.NAME = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Вы вышли.");
                        fl = false;
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
