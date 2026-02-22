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
            bool run = true;
            while (run)
            {
                Menu.menu.Show();
                int choice = readclass.ReadValue<int>("Выберите пункт меню: ", int.TryParse);
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Выход из программы...");
                        run = false;
                        break;
                        case 1:
                        Ex1.exercise1();
                        Console.ReadLine();
                        break;
                        case 2:
                        Ex2.exercise2();
                        Console.ReadLine();
                        break;
                        case 3:
                        Ex3.exercise3();
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
