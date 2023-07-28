// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// Console.WriteLine("Введите кол-во чисел :");
// int m = Convert.ToInt32(Console.ReadLine());

// int count = 0;
// for(int i = 0; i < m; i ++)
// {
// Console.WriteLine($"Введите число {i+1}");
// int num =Convert.ToInt32(Console.ReadLine());

// if (num > 0)
// count++ ;
// }
// System.Console.WriteLine($"Количество положительных чисел - {count}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//  задаются пользователем.


// Console.Write("k1 = ");
// double k1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("b1 = ");
// double b1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("k2 = ");
// double k2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("b2 = ");
// double b2 = Convert.ToInt32(Console.ReadLine());

// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * x + b1;

// Console.WriteLine($"Координаты точки пересечения (x = {x}, y = {y})");



// Задача 47. Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// int rows = 3;
// int columns = 2;
// double[,] matrix = new double[rows,columns];
// var random = new Random() ;  

// for(int i = 0; i < matrix.GetLength(0) ; i++)  
// {
//     for(int j = 0; i < matrix.GetLength(1); i++)  
//     {
//         matrix[i,j] = random.NextDouble()*20;
//         Console.Write(matrix[i,j]+" ");  
//     }

//     System.Console.WriteLine();
// }
// не выводит строки

// Задача 50. Напишите программу, которая на вход принимает
//  позиции элемента в двумерном массиве, и возвращает значение этого элемента 
//  или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int rows = 4;
// int columns = 4;
// int [,] matrix = new int [rows,columns];  
// var random = new Random();  

// for (int i= 0; i < matrix.GetLength(0); i++ )
// {
//   for( int j = 0; j < matrix.GetLength(1); j++)
//   {
//     matrix[i,j] = random.Next(0,10);
//     Console.Write(matrix[i,j]+" ");
//   }

// Console.WriteLine();
//  }

// Console.Write("Введите номер строки: ");
// int rowNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер столбца: ");
// int colNumber = Convert.ToInt32(Console.ReadLine());

// if (rowNumber > 0 && rowNumber <= rows && colNumber > 0 && colNumber <= columns)
// Console.WriteLine(matrix[rowNumber - 1, colNumber - 1]);

// else
// Console.WriteLine("Такого числа в массиве нет");


// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int rows = 3;
// int columns = 4;
// int [,] matrix = new int[rows,columns];
// var random = new Random();  

// for(int i = 0; i < matrix.GetLength(0); i++)
// { for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = random.Next(0,10);
//         System.Console.Write(matrix[i,j] +" ");
//     }
//    Console.WriteLine();
// }

// int sum;
// double average;
// int count = rows;

// for (int j = 0; j < columns; j++)
// {
// sum = 0;

// for(int i = 0; i  < rows; i++)
//     {
//        sum += matrix[i, j];
//     }
                
//       average = (double)sum / count;
//       Console.WriteLine($"Среднее арифметическое в столбце {j + 1}: " + average);
// }