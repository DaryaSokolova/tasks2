using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface IMovable
    {
        int PositionX { get; } //Положение объекта по оси Х
        int PositionY { get; } //Положение объекта по оси У
        void MoveToX(int valueX); //Движение по Х
        void MoveToY(int valueY); //Движение по Y
    }
}
