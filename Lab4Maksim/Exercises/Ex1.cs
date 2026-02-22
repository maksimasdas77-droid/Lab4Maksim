using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Maksim
{
    internal class Ex1
    {
        public static void exercise1()
        {
            int x;
            int y;
            int greater;
            Utis.ReadTwo(out x, out y);
            //x = readclass.ReadValue<int>("введите X: ", int.TryParse); заменил двойной ввод одним методом
            //y = readclass.ReadValue<int>("Введите Y: ", int.TryParse);
            greater = Utis.Greater(x, y);
            Console.WriteLine($"наибольшее значение {greater}");
        }
    }
}
