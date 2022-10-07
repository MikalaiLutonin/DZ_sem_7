// // ================ Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// // m = 3, n = 4.
// // 1 7 -2 -85
// // 1 -3 8 -9
// // 8 7 -7 9

// Console.Clear();
// Console.Write("Количество строк m: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Количество столбцов n: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, -9, 10);             //создание двумерного массива
// PrintArray(array);                                       //печать двумерного массива в консоль




// // =============== Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // i = 4, j = 2 -> такого числа в массиве нет
// // i = 1, j = 3 -> 2

// Console.Clear();
// Console.WriteLine("Имеем двумерный массив [5,5]:");
// int[,] array = GetArray(5, 5, 0, 10);                   //создание двумерного массива
// PrintArray(array);                                       //печать двумерного массива в консоль
// Console.Write("Введите индекс строки элемента: ");
// int i_row = int.Parse(Console.ReadLine()!);
// Console.Write("Введите индекс столбца элемента: ");
// int i_column = int.Parse(Console.ReadLine()!);
// ElementValue(i_row, i_column);                              //вызов невозвращаемого метода




// ============== Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.Write("Задайте количество строк в двумерном массиве: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Задайте количество столбцов в двумерном массиве: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Исходный массив [{rows},{columns}]:\n");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
ArithmeticAverage(array);


// void ElementValue(int i, int j)                      //метод вывода значения элемента
// {
//     if (i < 5 && j < 5)
//     {
//         Console.Write($"Значение этого элемента: {array[i, j]}");
//     }
//     else { Console.Write("Такого числа в массиве нет :("); }
// }

void ArithmeticAverage(int[,] array)                 //вывод среднего арифметического каждого столбца
{
for (int j = 0; j < array.GetLength(1); j++)
{
    double Summ = 0;
    int i = 0;
    for (; i < array.GetLength(0); i++)
    {
        Summ += array[i, j];
    }
    double AAverage = Summ / i;
    Console.WriteLine($"Среднее арифметическое {j + 1}-го столбца: {AAverage:F2}");
}
}

int[,] GetArray(int m, int n, int minValue, int maxValue)   //метод создания и заполнения двумерного массива рандомными числами 
{
    int[,] result = new int[m, n];                          //создание пустого двумерного массива
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] array)                    //метод вывода двумерного массива на печать
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
