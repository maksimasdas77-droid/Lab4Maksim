using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Maksim
{
    internal class Ex2
    {
        public static void exercise2()
        {
            int x;
            int y;
            Utis.ReadTwo(out x, out y);
            //x = readclass.ReadValue<int>("Введите X: ", int.TryParse);
            //y = readclass.ReadValue<int>("Введите Y: ", int.TryParse);
            Console.WriteLine("До метода Swap " + x + "," + y);
            Utis.Swap(ref x, ref y);
            Console.WriteLine("после метода Swap " + x + "," + y);
        }
    }
}
