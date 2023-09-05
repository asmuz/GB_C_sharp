/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц. */

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
        System.Console.WriteLine();
    }
}

int[,] ArraysMultiplication(int[,] array1, int[,] array2)
{
    int rows = array1.GetLength(0);
    int cols = array1.GetLength(1);
    int[,] result = new int[rows, cols];
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            result[row, col] = array1[row, col] * array2[row, col];
        }
    }
    return result;
}

int[,] array1 = Get2DArray(5, 5, 0, 10);
int[,] array2 = Get2DArray(5, 5, 0, 10);

Print2DArray(array1);
Print2DArray(array2);
Print2DArray(ArraysMultiplication(array1, array2));