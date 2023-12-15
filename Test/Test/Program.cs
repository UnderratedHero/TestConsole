using Test.Four;
using Test.One;
using Test.Three;
using Test.Two;

namespace Test
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                var menu = @"
Введите номер меню:
1)Работа с матрицами (массивы);
2)Рекурсивыне алгоритмы;
3)Хеширование данных;
4)ООП;
0)Выход.";
                Console.Clear();
                Console.WriteLine(menu);
                var menuNumber = Convert.ToInt32(Console.ReadLine());
                switch (menuNumber)
                {
                    case 1:
                        {
                            taskOne task = new();
                            task.Menu();
                            break;
                        }
                    case 2:
                        {
                            taskTwo task = new();
                            task.Menu();
                            break;
                        }
                    case 3:
                        {
                            taskThree task = new();
                            task.Menu();
                            break;
                        }
                    case 4:
                        {
                            taskFour task= new();
                            task.Menu(); 
                            break;
                        }
                    case 0:
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Вы ввели неправильное число");
                            break;
                        }
                }
            }
        }
    }
}