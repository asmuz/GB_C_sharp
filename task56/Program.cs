/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов. */

Console.Clear();

int[,] Get2DArray(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    System.Console.Write($"\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.Write("Сумма: " + SumByRows(array, i));
        System.Console.WriteLine();
    }
}

int SumByRows(int[,] array, int row)    // считаем сумму всех элементов заданной строки массива
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum += array[row, i];
    }
    return sum;
}

int SmallestRowSum(int[,] array)
{
    int row = 0;
    int smallest = SumByRows(array, 0);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (SumByRows(array, i) < smallest)
        {
            row = i;
            smallest = SumByRows(array, i);
        }
    }
    return row;
}

int[,] arr = Get2DArray(5, 7, 0, 10);
Print2DArray(arr);
System.Console.WriteLine("Строка с наименьшей суммой элементов: " + SmallestRowSum(arr));