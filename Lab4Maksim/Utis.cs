using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Maksim
{
    internal class Utis
    {
        public static void ReadTwo(out int x, out int y)
        {
            x = readclass.ReadValue<int>("Введите X: ", int.TryParse); 
            y = readclass.ReadValue<int>("Введите Y: ", int.TryParse);
        }
        public static int Greater(int a, int b)
        {
            if(a == b)
            {
                Console.WriteLine("значения равны");
            }
            return a > b ? a : b;
            //if (a > b) return a;
            //else return b;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static bool Factorial(int n, out int answer)
        {
            int k;
            //bool ok = true;
            if (n < 0)
            {
                answer = 0;
                return false;
            }
            try
            {
                checked
                {
                    answer = 1;
                    for (k = 2; k <= n; k++)
                    {
                        answer *= k;
                    }
                }
            }
            catch(Exception) {
                answer = 0;
                return false;
            }
            return true;
        }
    }
}
