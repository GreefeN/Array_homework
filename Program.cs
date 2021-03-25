﻿using System;
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
            #region Задание 1.
            // Заказчик просит вас написать приложение по учёту финансов
            // и продемонстрировать его работу.
            // Суть задачи в следующем: 
            // Руководство фирмы по 12 месяцам ведет учет расходов и поступлений средств. 
            // За год получены два массива – расходов и поступлений.
            // Определить прибыли по месяцам
            // Количество месяцев с положительной прибылью.
            // Добавить возможность вывода трех худших показателей по месяцам, с худшей прибылью, 
            // если есть несколько месяцев, в некоторых худшая прибыль совпала - вывести их все.
            // Организовать дружелюбный интерфейс взаимодействия и вывода данных на экран

            // Пример
            //       
            // Месяц      Доход, тыс. руб.  Расход, тыс. руб.     Прибыль, тыс. руб.
            //     1              100 000             80 000                 20 000
            //     2              120 000             90 000                 30 000
            //     3               80 000             70 000                 10 000
            //     4               70 000             70 000                      0
            //     5              100 000             80 000                 20 000
            //     6              200 000            120 000                 80 000
            //     7              130 000            140 000                -10 000
            //     8              150 000             65 000                 85 000
            //     9              190 000             90 000                100 000
            //    10              110 000             70 000                 40 000
            //    11              150 000            120 000                 30 000
            //    12              100 000             80 000                 20 000
            // 
            // Худшая прибыль в месяцах: 7, 4, 1, 5, 12
            // Месяцев с положительной прибылью: 10

            ////int m = 12; //количество месяцев
            ////int[] income = new int[m];  //доход
            ////int[] expense = new int[m]; //расход
            ////int[] profit = new int[m];  //прибыль, убытки
            ////int[] sortedProfit = new int[profit.Length];    //массив для сортировки
            ////byte countProfitMonth = 0;
            Random rnd = new Random();

            ////for (int i = 0; i < m; i++) //цикл заполнения таблицы, + счётчик месяцев с прибылью
            ////{
            ////    income[i] = rnd.Next(0, 200_000);
            ////    expense[i] = rnd.Next(10_000, 100_000);
            ////    profit[i] = income[i] - expense[i];
            ////    if (profit[i] > 0) countProfitMonth++;
            ////}

            ////Console.WriteLine($"Месяц{"Доход, тыс. руб",17}{"Расход, тыс. руб",18}{"Прибыль, тыс. руб.",20}");  //оглавление колонок таблицы
            ////for (int i = 0; i < m; i++) //вывод данных таблицы
            ////{
            ////    Console.Write($"{(i + 1),5}{income[i],17}{expense[i],18}{profit[i],20}\n");
            ////}

            ////Array.Copy(profit, sortedProfit, profit.Length);    //копирование  данных из одного массива в другой для сортировки
            ////Array.Sort(sortedProfit);   //сортировка

            ////Console.Write("Худшая прибыль в месяцах: ");
            ////for (int i = 0; i < 3; i++) //вывод месяцев с убытками
            ////{
            ////    for (int j = 0; j < profit.Length; j++)
            ////    {
            ////        if (sortedProfit[i] == profit[j])
            ////        {
            ////            Console.Write($"{j + 1} ");
            ////        }
            ////    }
            ////}

            ////Console.WriteLine();
            ////Console.WriteLine($"Месяцев с положительной прибылью: {countProfitMonth}"); //вывод количества месяцев с прибылью
            ////Console.ReadKey();
            #endregion

            #region Задание 2
            // Заказчику требуется приложение строящее первых N строк треугольника паскаля. N < 25
            // 
            // При N = 9. Треугольник выглядит следующим образом:
            //                                 1
            //                             1       1
            //                         1       2       1
            //                     1       3       3       1
            //                 1       4       6       4       1
            //             1       5      10      10       5       1
            //         1       6      15      20      15       6       1
            //     1       7      21      35      35       21      7       1
            //                                                              
            //                                                              
            // Простое решение:                                                             
            // 1
            // 1       1
            // 1       2       1
            // 1       3       3       1
            // 1       4       6       4       1
            // 1       5      10      10       5       1
            // 1       6      15      20      15       6       1
            // 1       7      21      35      35       21      7       1
            // 
            // Справка: https://ru.wikipedia.org/wiki/Треугольник_Паскаля

            ////Console.Write("Введите количество строк: ");
            ////int raw = int.Parse(Console.ReadLine());    //вводим высоту пирамиды в строках
            ////int[][] triangleOfPascal = new int[raw][];
            ////for (int i = 0; i < raw; i++)   //создаем массивы для пирамиды
            ////{
            ////    triangleOfPascal[i] = new int[i + 1];
            ////}

            ////for (int i = 0; i <= triangleOfPascal.GetUpperBound(0); i++)    //построчечное заполнение массива массивов
            ////{

            ////    //????

            ////    for (int j = 0; j < triangleOfPascal[i].Length; j++)    //заполнение пирамиды
            ////    {
            ////        if (i == 0 || i == 1)   //исключение вычислений для первых двух массивов, прост присваивание значений
            ////        {
            ////            triangleOfPascal[i][j] = 1;
            ////        }
            ////        else //переход к заполнению строк пирамиды ниже первых двух
            ////        {
            ////            if (j == 0 || j == triangleOfPascal[i].GetUpperBound(0))    //присваивание значений крайним элементами массива
            ////            {
            ////                triangleOfPascal[i][j] = 1;
            ////            }
            ////            else //заполнение внутренних элементов массивов
            ////            {
            ////                triangleOfPascal[i][j] = triangleOfPascal[i - 1][j] + triangleOfPascal[i - 1][j - 1];
            ////            }
            ////        }
            ////        Console.Write($" {triangleOfPascal[i][j]} ");
            ////    }
            ////    Console.WriteLine();
            ////}
            ////Console.ReadKey();

            #endregion

            #region Задание 3.1
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
            //
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
            Console.ReadKey();
            #endregion
        }
    }
}
