using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.One
{
    internal class taskOne
    {
        public void Menu()
        {
            while (true)
            {
                var menu = @"
Введите номер меню:
1)Сумма всех элементов главной диагонали;
2)Сумма всех элементов, кратных 3-ем;
0)Выход.";
                Console.Clear();
                Console.WriteLine(menu);
                var menuNumber = Convert.ToInt32(Console.ReadLine());
                switch (menuNumber)
                {
                    case 1:
                        {
                           CalculateMatrixDiagonal(GetArray());
                            break;
                        }
                    case 2:
                        {
                            CalculateDivisibleElements(GetArray());
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

        private int[,] GetArray()
        {
            Console.Clear();
            Console.WriteLine("Введите размеры матрицы\nМатрица будет сгенерирована автоматически и случайным образом:");
            Console.WriteLine("Количество строк:");
            var rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество столбцов:");
            var columns = Convert.ToInt32(Console.ReadLine());
            var array = new int[rows, columns];
            var random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(-100,100);
                }
            }
            Console.WriteLine("Ваш массив: ");
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j< columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            return array;
        }

        private void CalculateMatrixDiagonal (int[,] array)
        {
            var sum = 0;
            for(int i =0; i<array.GetLength(0);i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i==j)
                    {
                        sum += array[i,j];
                    }
                }
            }
            Console.WriteLine("Результат суммы элементов главной диагонали вашей матрицы: " + sum);
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }

        private void CalculateDivisibleElements(int[,] array)
        {
            var sum = 0;
            foreach(var element in array )
            {
                if(element%3!=0)
                {
                    continue;
                }
                sum += element;
            }
            Console.WriteLine("Результат суммы элементов, кратных 3-ем: " + sum);
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }

    }
}
