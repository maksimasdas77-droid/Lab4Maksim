using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Maksim
{
    internal class Ex3
    {
        public static void exercise3()
        {
            int x;
            int answer;
            bool ok;
            x = readclass.ReadValue<int>("Введите X для факториала: ", int.TryParse);
            ok = Utis.Factorial(x, out answer);
            if (ok) Console.WriteLine($"Факториал({x}) = {answer}"); //этот нравится больше
            //if (ok) Console.WriteLine("Factorial(" + x + ") = " + answer); мне не нравится такой вывод
            else Console.WriteLine("Не удалось посчитать факториал");
        }
    }
}
