using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Maksim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int greater;
            bool run = true;
            while (run)
            {
                Console.Clear();
                Console.WriteLine("+++меню+++");
                Console.WriteLine("0. Выход из программы");
                Console.WriteLine("1. Упражнение 1. Использование параметров в методах, возвращающих значения");
                Console.WriteLine("2. Упражнение 2. Использование в методах параметров, передаваемых по ссылке");
                Console.WriteLine("3. Упражнение 3. Использование возвращаемых параметров в методах");
                Console.WriteLine("4. пока не готово");
                int choice = readclass.ReadValue<int>("Выберите пункт меню: ", int.TryParse);
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Выход из программы...");
                        run = false;
                        break;
                        case 1:
                        Utis.ReadTwo(out x, out y);
                        //x = readclass.ReadValue<int>("введите X: ", int.TryParse); заменил двойной ввод одним методом
                        //y = readclass.ReadValue<int>("Введите Y: ", int.TryParse);
                        greater = Utis.Greater(x, y);
                        Console.WriteLine($"наибольшее значение {greater}");
                        Console.ReadLine();
                        break;
                        case 2:
                        Utis.ReadTwo(out x, out y);
                        //x = readclass.ReadValue<int>("Введите X: ", int.TryParse);
                        //y = readclass.ReadValue<int>("Введите Y: ", int.TryParse);
                        Console.WriteLine("До метода Swap " + x + "," + y);
                        Utis.Swap(ref x, ref y);
                        Console.WriteLine("после метода Swap " + x + "," + y);
                        Console.ReadLine();
                        break;
                        case 3:
                        int f;
                        bool ok;
                        x = readclass.ReadValue<int>("Введите X для факториала: ", int.TryParse);
                        ok = Utis.Factorial(x, out f);
                        if (ok) Console.WriteLine("Factorial(" + x + ") = " + f);
                        else Console.WriteLine("Не удалось посчитать факториал");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Нет такого пункта меню");
                        Console.ReadLine();
                        break;
                }
            }
           
        }
    }
}
