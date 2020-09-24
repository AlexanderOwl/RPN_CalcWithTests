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
                string input = Console.ReadLine();
                RPN.PrintRPN(input);
                Console.WriteLine("Result: "+RPN.Calculate(input)); //Считываем, и выводим результат
                Console.WriteLine();
            }
        }
    }
}
