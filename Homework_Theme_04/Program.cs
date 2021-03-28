using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // *** Задание 3.3
            // Заказчику требуется приложение позволяющщее перемножать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести нельзя - сообщить об этом
            //  
            //  |  1  3  5  |   |  1  3  4  |   | 22  48  57  |
            //  |  4  5  7  | х |  2  5  6  | = | 35  79  95  |
            //  |  5  3  1  |   |  3  6  7  |   | 14  36  45  |
            //
            //  
            //                  | 4 |   
            //  |  1  2  3  | х | 5 | = | 32 |
            //                  | 6 |  
            //

            Random rnd = new Random();
            Console.Write("Введите количество строк для первого массива и количество столбцов для второго массива: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов для первого массива и количество строк для второго массива: ");
            int y = int.Parse(Console.ReadLine());
            int[,] matrix = new int[x, y];
            int[,] matrix2 = new int[y, x];
            int e = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matrix[i, j] = rnd.Next(0, 10);
                    matrix2[j, i] = rnd.Next(0, 10);
                }
            }

            int w;
            if (x > y) w = x;
            else if (y > x) w = y;
            else w = x;


            for (int i = 0; i < w; i++)
            {
                if (i < x)
                {
                    for (int l = 0; l < y; l++)
                    {
                        Console.Write($"{matrix[i, l],2}");

                    }
                    if (x > y && i >= x - y - 1 && x - y > y)
                    {
                        for (int r = 0; r < 6 + x * 2; r++)
                        {
                            Console.Write(' ');
                        }
                    }
                    else if (x > y && i > x - y && x - y < y)
                    {
                        for (int r = 0; r < 6 + x * 2; r++)
                        {
                            Console.Write(' ');
                        }
                    }


                }
                if (i < y)
                {

                    for (int l = 0; l < x; l++)
                    {
                        if (i < x && l == 0)
                        {
                            for (int r = 0; r < 3; r++)
                            {
                                if (r == 1 && i == 0)
                                {
                                    Console.Write('*');
                                }
                                else
                                {
                                    Console.Write(' ');
                                }

                            }
                        }

                        if (i > x - 1 && l == 0)
                        {
                            for (int r = 0; r < y * 2 + 3; r++)
                            {
                                Console.Write(' ');
                            }
                        }

                        Console.Write($"{matrix2[i, l],2}");
                        if (l == x - 1)
                        {
                            for (int r = 0; r < 3; r++)
                            {
                                if (r == 1 && i == 0)
                                {
                                    Console.Write('=');
                                }
                                else
                                {
                                    Console.Write(' ');
                                }

                            }
                        }

                    }
                }

                if (i < x)
                {
                    for (int j = 0; j < x; j++)
                    {
                        for (int t = 0; t < y; t++)
                        {
                            e += matrix[i, t] * matrix2[t, j];
                        }
                        Console.Write($"{e,4}");
                        e = 0;
                    }
                }

                Console.WriteLine();




            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < x; i++)
            {
                for (int l = 0; l < y; l++)
                {
                    Console.Write($"{matrix[i, l],2}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < y; i++)
            {

                for (int l = 0; l < x; l++)
                {
                    Console.Write($"{matrix2[i, l],2}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    for (int t = 0; t < y; t++)
                    {
                        e += matrix[i, t] * matrix2[t, j];
                    }
                    Console.Write($"{e,4}");
                    e = 0;
                }
                Console.WriteLine();
            }


            Console.ReadKey();

        }
    }
}
