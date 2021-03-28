using System;

namespace Homework4_task3_part1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заказчику требуется приложение позволяющщее умножать математическую матрицу на число
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матрицы_на_число
            // Добавить возможность ввода количество строк и столцов матрицы и число,
            // на которое будет производиться умножение.
            // Матрицы заполняются автоматически. 
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //
            //      |  1  3  5  |   |  5  15  25  |
            //  5 х |  4  5  7  | = | 20  25  35  |
            //      |  5  3  1  |   | 25  15   5  |

            Random rnd = new Random();
            Console.Write("Введите количество строк: ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int c = int.Parse(Console.ReadLine());
            int[,] matrix = new int[r, c];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matrix[i, j] = rnd.Next(0, 10);
                }
            }

            Console.Write("Введите число на которое нужно умножить: ");
            int mult = int.Parse(Console.ReadLine());
            for (int i = 0; i < r; i++)
            {
                if (i != r / 2)
                {
                    Console.Write("\t\t");
                }
                else
                {
                    Console.Write($"\t{mult} x\t");
                }
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"{matrix[i, j],3}");
                    if ((i != r / 2) && j == c - 1)
                    {
                        Console.Write("\t\t");
                        for (int m = 0; m < c; m++)
                        {
                            Console.Write($"{matrix[i, m] * mult,3}");
                        }
                    }
                    else if ((i == r / 2) && (j == c - 1))
                    {
                        Console.Write("\t=\t");
                        for (int m = 0; m < c; m++)
                        {
                            Console.Write($"{matrix[i, m] * mult,3}");
                        }
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
