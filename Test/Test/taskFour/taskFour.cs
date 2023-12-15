using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Test.Four
{
    internal class taskFour
    {
        public void Menu()
        {
            while (true)
            {
                var menu = @"
Введите номер меню:
1)Периметр и площадь круга;
2)Периметр и площадь прямоугольника;
3)Периметр и площадь квадрата;
4)Периметр и площадь ромба;
0)Выход.";
                Console.Clear();
                Console.WriteLine(menu);
                var menuNumber = Convert.ToInt32(Console.ReadLine());
                switch (menuNumber)
                {
                    case 1:
                        {
                            while(true)
                            {
                                Console.Clear();
                                Console.WriteLine("Введите радиус: ");
                                var radius = Convert.ToInt32(Console.ReadLine());
                                if (radius > 0)
                                {
                                    Circle circle = new(radius);
                                    Console.WriteLine($"Площадь: {circle.GetSquare()}, Периметр: {circle.GetPerimeter()}");
                                    Console.WriteLine("Для продолжения нажмите любую клавишу");
                                    Console.ReadKey();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Радиус отрицательный или равен нулю!");
                                    Console.WriteLine("Для продолжения нажмите любую клавишу");
                                    Console.ReadKey();
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Введите высоту: ");
                                var height = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите ширину: ");
                                var width = Convert.ToInt32(Console.ReadLine());
                                if (width > 0 && height > 0)
                                {
                                    Rectangle rectangle = new(width, height);
                                    Console.WriteLine($"Площадь: {rectangle.GetSquare()}, Периметр {rectangle.GetPerimeter()}");
                                    Console.WriteLine("Для продолжения нажмите любую клавишу");
                                    Console.ReadKey();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Значения отрицательные или равны нулю!");
                                    Console.WriteLine("Для продолжения нажмите любую клавишу");
                                    Console.ReadKey();
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Введите длину стороны: ");
                                var sideLength = Convert.ToInt32(Console.ReadLine());
                                if (sideLength > 0)
                                {
                                    Square square = new(sideLength);
                                    Console.WriteLine($"Площадь: {square.GetSquare()}, Периметр {square.GetPerimeter()}");
                                    Console.WriteLine("Для продолжения нажмите любую клавишу");
                                    Console.ReadKey();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Отрицательная длина или равна нулю!");
                                    Console.WriteLine("Для продолжения нажмите любую клавишу");
                                    Console.ReadKey();
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Введите первую диагональ: ");
                                var firstDiagonal = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите вторую диагональ: ");
                                var secondDiagonal = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите длину стороны");
                                var sideLength = Convert.ToInt32(Console.ReadLine());
                                if (secondDiagonal > 0 && firstDiagonal > 0 && sideLength > 0)
                                {
                                    Rhombus rhombus = new(firstDiagonal, secondDiagonal, sideLength);
                                    Console.WriteLine($"Площадь: {rhombus.GetSquare()}, Периметр {rhombus.GetPerimeter()}");
                                    Console.WriteLine("Для продолжения нажмите любую клавишу");
                                    Console.ReadKey();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Значения отрицательные или равны нулю!");
                                    Console.WriteLine("Для продолжения нажмите любую клавишу");
                                    Console.ReadKey();
                                }
                            }
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
