using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPN_CalcWithTests
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) //Бесконечный цикл
            {
                Console.Write("Input expression: "); //Предлагаем ввести выражение
                Console.WriteLine(RPN.Calculate(Console.ReadLine())); //Считываем, и выводим результат
            }
        }
    }
}
