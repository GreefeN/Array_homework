using System;

namespace Homewrk4_task3_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ** Задание 3.2
            // Заказчику требуется приложение позволяющщее складывать и вычитать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Сложение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //  |  1  3  5  |   |  1  3  4  |   |  2   6   9  |
            //  |  4  5  7  | + |  2  5  6  | = |  6  10  13  |
            //  |  5  3  1  |   |  3  6  7  |   |  8   9   8  |
            //  
            //  
            //  |  1  3  5  |   |  1  3  4  |   |  0   0   1  |
            //  |  4  5  7  | - |  2  5  6  | = |  2   0   1  |
            //  |  5  3  1  |   |  3  6  7  |   |  2  -3  -6  |

            Random rnd = new Random();
            Console.Write("Введите количество строк: ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int c = int.Parse(Console.ReadLine());
            int[,] matrix = new int[r, c];
            int[,] matrix2 = new int[r, c];


            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matrix[i, j] = rnd.Next(0, 10);
                    matrix2[i, j] = rnd.Next(0, 10);
                }
            }

            for (int o = 0; o < 2; o++)
            {
                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        Console.Write($"{matrix[i, j],3}");
                    }
                    if( i != r / 2)
                    {
                        Console.Write($"\t\t");
                    }
                    else if( i == r/2 && o == 0)
                    {
                        Console.Write($"\t+\t");
                    }else if(i == r / 2 && o == 1)
                    {
                        Console.Write($"\t-\t");
                    }
                    for (int j = 0; j < c; j++)
                    {
                        Console.Write($"{matrix2[i, j],3}");
                    }
                    if (i == r / 2) Console.Write("\t=\t"); else Console.Write("\t\t");
                    for (int j = 0; j < c; j++)
                    {
                        if(o == 0)
                        {
                            Console.Write($"{(matrix[i, j] + matrix2[i, j]),3}");
                        }
                        else
                        {
                            Console.Write($"{(matrix[i, j] - matrix2[i, j]),3}");
                        }
                        
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n");
            }
            





            Console.ReadKey();
        }
    }
}
