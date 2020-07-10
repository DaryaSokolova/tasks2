using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp211
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStringClass newString = new MyStringClass("Привет!");
            MyStringClass newString1 = new MyStringClass("Привет, как дела?");

            //Console.WriteLine(MyStringClass.Compare(newString, newString1));
            //Console.WriteLine(newString1.Concat(newString1).chars);
            //Console.WriteLine(newString.IndexOf('к'));
            //Console.WriteLine(newString.LastIndexOf('!'));
            //Console.WriteLine(newString.Substring(1, 3).chars);
            //Console.WriteLine(newString.Remove(0, 2).chars);
        }
    }
}
