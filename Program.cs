// Задача 54: Задайте двумерный массив. Напишите программу,
//  которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// Console.Write("Введите число строк: ");
//             int rows = Convert.ToInt32(Console.ReadLine());
//             Console.Write("Введите число столбцов: ");
//             int columns = Convert.ToInt32(Console.ReadLine());

//             int[,] matrix = new int[rows, columns];
//             var random = new Random();

//             void GetArray()
//             {
//                 for (int i = 0; i < matrix.GetLength(0); i++)
//                 {
//                     for (int j = 0; j < matrix.GetLength(1); j++)
//                     {
//                         matrix[i, j] = random.Next(1, 10);
//                     }
//                 }
//             }

//             void PrintArray()
//             {
//                 for (int i = 0; i < matrix.GetLength(0); i++)
//                 {
//                     for (int j = 0; j < matrix.GetLength(1); j++)
//                     {
//                         Console.Write(matrix[i, j] + " ");
//                     }

//                     Console.WriteLine();
//                 }
//             }

//             void SortRowsByDescending()
//             {
//                 int swap;

//                 for (int rowIndex = 0; rowIndex < rows; rowIndex++)
//                 {
//                     for (int colIndexI = 0; colIndexI < columns; colIndexI++)
//                     {
//                         for (int colIndexJ = colIndexI + 1; colIndexJ < columns; colIndexJ++)
//                         {
//                             if (matrix[rowIndex, colIndexI] < matrix[rowIndex, colIndexJ])
//                             {
//                                 swap = matrix[rowIndex, colIndexI];
//                                 matrix[rowIndex, colIndexI] = matrix[rowIndex, colIndexJ];
//                                 matrix[rowIndex, colIndexJ] = swap;
//                             }
//                         }
//                     }
//                 }
//             }

//             GetArray();
//             PrintArray();
//             SortRowsByDescending();
//             Console.WriteLine("**********");
//             PrintArray();

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
//             Console.Write("Введите число строк: ");
//             int rows = Convert.ToInt32(Console.ReadLine());
//             Console.Write("Введите число столбцов: ");
//             int columns = Convert.ToInt32(Console.ReadLine());

//             int[,] matrix = new int[rows, columns];

//             var random = new Random();

//             void GetArray()
//             {
//                 for (int i = 0; i < matrix.GetLength(0); i++)
//                 {
//                     for (int j = 0; j < matrix.GetLength(1); j++)
//                     {
//                         matrix[i, j] = random.Next(1, 10);
//                     }
//                 }
//             }

//             void PrintArray()
//             {
//                 for (int i = 0; i < matrix.GetLength(0); i++)
//                 {
//                     for (int j = 0; j < matrix.GetLength(1); j++)
//                     {
//                         Console.Write(matrix[i, j] + " ");
//                     }

//                     Console.WriteLine();
//                 }
//             }

//             GetArray();
//             PrintArray();
//             Console.WriteLine("**********");

//             int minSum = 0;
//             int rowNumber = 1;
//             int sum;

            //вычисляем сумму первой строки
            // for (int j = 0; j < columns; j++)
            // {
            //     minSum += matrix[0, j];
            // }

            //затем сравниваем её с суммами последующих строк
            //выбираем наименьшую и запоминаем номер строки
            // for (int i = 1; i < rows; i++)
            // {
            //     sum = 0;

            //     for (int j = 0; j < columns; j++)
            //     {
            //         sum += matrix[i, j];
            //     }

            //     if (minSum > sum)
            //     {
            //         minSum = sum;
            //         rowNumber = i + 1;
            //     }
            // }

            // Console.WriteLine($"Минимальная сумма: {minSum}, строка {rowNumber}");


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

        //  Console.Write("Введите число строк: ");
        //     int rows = Convert.ToInt32(Console.ReadLine());
        //     Console.Write("Введите число столбцов: ");
        //     int columns = Convert.ToInt32(Console.ReadLine());
        //     Console.Write("Введите число уровней: ");
        //     int levels = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine();

        //     int[,,] matrix = new int[levels, rows, columns];

        //     var random = new Random();

        //     void GetArray()
        //     {
        //         for (int k = 0; k < levels; k++)
        //         {
        //             for (int i = 0; i < rows; i++)
        //             {
        //                 for (int j = 0; j < columns; j++)
        //                 {
        //                     matrix[k, i, j] = random.Next(0, 100);
        //                 }
        //             }
        //         }
        //     }

        //     void PrintArray()
        //     {
        //         for (int k = 0; k < levels; k++)
        //         {
        //             for (int i = 0; i < rows; i++)
        //             {
        //                 for (int j = 0; j < columns; j++)
        //                 {
        //                     Console.Write($"{matrix[k, i, j]}({k},{i},{j}) ");
        //                 }
                        
        //                 Console.WriteLine();
        //             }

        //             Console.WriteLine("************");
        //         }
        //     }

        //     GetArray();
        //     PrintArray();   

//         Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// 64 Задайте значение N. Напишите программу, которая выведет все натуральные числа
//  в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void PrintNumbers(int number)
//             {
//                 if (number > 0)
//                 {
//                     Console.Write(number + ", ");
//                     PrintNumbers(number - 1);
//                 }
//                 else
//                 {
//                     Console.WriteLine();
//                 }
//             }

//             Console.Write("Введите значение N: ");
//             int n = int.Parse(Console.ReadLine());
//             Console.WriteLine("Результат:");
//             PrintNumbers(n);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//  натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int SumRange(int n1, int m1)
//             {
//                 int sum = n1;

//                 if (n1 < m1)
//                 {
//                     sum += SumRange(++n1, m1);
//                 }

//                 return sum;
                
//             }

        
//             Console.WriteLine($"Результат: {SumRange(n, m)}");

