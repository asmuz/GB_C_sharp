/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.*/

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

void Print2DArray(int[,] arrayToPrint)
{
    System.Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write(arrayToPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] SortByRows(int[,] array, int row)    // сортируем пузырьком заданную строку массива
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (array[row, j] < array[row, j + 1])
            {
                temp = array[row, j];
                array[row, j] = array[row, j + 1];
                array[row, j + 1] = temp;
            }
        }
    }
    return array;
}

int[,] SortingArray(int[,] array)           // перебираем все строки массива и сортируем
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        SortByRows(array, row);
    }
    return array;
}

int[,] array = Get2DArray(5, 7, 0, 10);

System.Console.WriteLine("Исходный массив:");
Print2DArray(array);

System.Console.WriteLine("Отсортированный массив:");
Print2DArray(SortingArray(array));