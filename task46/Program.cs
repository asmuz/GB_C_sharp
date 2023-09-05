/* Задайте двумерный массив размером m×n, заполненный случайными целыми числами.*/

Console.Clear();

int[,] Get2DArray(int cols, int rows, int deviation)
{
    int[,] array = new int[cols, rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(-deviation, deviation);
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
            System.Console.Write(arrayToPrint[i,j] +"\t");
        }
        System.Console.WriteLine();
    }
}
int[,] randomArray = GetRandom2DArray(5, 5, 10);
Print2DArray(randomArray);

int [,] arr = Get2DArray(5,5,10);
Print2DArray(arr);