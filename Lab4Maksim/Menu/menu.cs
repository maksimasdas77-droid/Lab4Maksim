using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Maksim.Menu
{
    internal class menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("+++меню+++");
            Console.WriteLine("0. Выход из программы");
            Console.WriteLine("1. Упражнение 1. Использование параметров в методах, возвращающих значения");
            Console.WriteLine("2. Упражнение 2. Использование в методах параметров, передаваемых по ссылке");
            Console.WriteLine("3. Упражнение 3. Использование возвращаемых параметров в методах");
            Console.WriteLine("4. Упражнение 4. Работа с массивами размерных типов");
            Console.WriteLine("5. Упражнение 5. Перемножение матриц");
        }
    }
}
