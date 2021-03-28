using System;

namespace Homework4_part2
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.Write("Введите количество строк: ");
            int raw = int.Parse(Console.ReadLine());    //вводим высоту пирамиды в строках
            int[][] triangleOfPascal = new int[raw][];
            for (int i = 0; i < raw; i++)   //создаем массивы для пирамиды
            {
                triangleOfPascal[i] = new int[i + 1];
            }

            for (int i = 0; i <= triangleOfPascal.GetUpperBound(0); i++)    //построчечное заполнение массива массивов
            {

                //????

                for (int j = 0; j < triangleOfPascal[i].Length; j++)    //заполнение пирамиды
                {
                    if (i == 0 || i == 1)   //исключение вычислений для первых двух массивов, прост присваивание значений
                    {
                        triangleOfPascal[i][j] = 1;
                    }
                    else //переход к заполнению строк пирамиды ниже первых двух
                    {
                        if (j == 0 || j == triangleOfPascal[i].GetUpperBound(0))    //присваивание значений крайним элементами массива
                        {
                            triangleOfPascal[i][j] = 1;
                        }
                        else //заполнение внутренних элементов массивов
                        {
                            triangleOfPascal[i][j] = triangleOfPascal[i - 1][j] + triangleOfPascal[i - 1][j - 1];
                        }
                    }
                    Console.Write($" {triangleOfPascal[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
