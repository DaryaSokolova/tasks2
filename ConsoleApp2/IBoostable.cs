using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface IBoostable
    {
        int speedNow { get; } //скорость сейчас
        void NewSpeed(int valueSpeed); // изменение скорости
    }
}
