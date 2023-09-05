/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();

int[,] Get2DArray(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void Print2DArray(int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write(arrayToPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void Arithmetic(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    double sum = 0;
    for (int col = 0; col < cols; col++)
    {
        System.Console.Write($"------\t");
    }
    System.Console.WriteLine();
    for (int col = 0; col < cols; col++)
    {
        for (int row = 0; row < rows; row++)
        {
            sum += array[row, col];
        }
        System.Console.Write($"{Math.Round(sum / rows, 2)}\t");
        sum = 0;
    }
}

int[,] arr = Get2DArray(4, 7, 1, 10);
Print2DArray(arr);
Arithmetic(arr);