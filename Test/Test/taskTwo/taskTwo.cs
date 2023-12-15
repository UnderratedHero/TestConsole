using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Two
{
    internal class taskTwo
    {
        public void Menu()
        {
            while (true)
            {
                var menu = @"
Введите номер меню:
1)Нахождение числа по порядковому номеру из последовательнсти Фибоначчи;
2)Возведение числа в любую степень;
0)Выход.";
                Console.Clear();
                Console.WriteLine(menu);
                var menuNumber = Convert.ToInt32(Console.ReadLine());
                switch (menuNumber)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Введите порядковый номер числа, которое хотите найти");
                            var numberIndex = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ваше число из последовательности Фибоначчи: " + FindFibonacciNumber(numberIndex));
                            Console.WriteLine("Для продолжения нажмите любую клавишу");
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Введите число и степень, в которую хотите возвести число");
                            Console.WriteLine("Введите число:");
                            var number = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите степень:");
                            var exponent = Convert.ToInt32(Console.ReadLine());
                            if(exponent>0)
                            {
                                Console.WriteLine("Ваше число в любой степени: " + Exponentiation(number, exponent));
                            }
                            else
                            {
                                var result = 1 / Exponentiation(number, -exponent);
                                Console.WriteLine("Ваше число в любой степени: " + (result));
                            }
                            Console.WriteLine("Для продолжения нажмите любую клавишу");
                            Console.ReadKey();
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

        private int FindFibonacciNumber(int numberIndex)
        {
            if (numberIndex < 2)
            {
                return numberIndex;
            }
            else
            {
                return FindFibonacciNumber(numberIndex - 1) + FindFibonacciNumber(numberIndex - 2);
            }
        }
        private float Exponentiation(int number, int exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }
            if(exponent == 1)
            {
                return number;
            }    
            exponent -= 1;
            return number * Exponentiation(number,exponent);
        }
    }
}
