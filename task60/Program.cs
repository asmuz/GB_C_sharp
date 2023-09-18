﻿/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. */

Console.Clear();

int[,,] Get3DArray()
{
    Console.Write("Сколько столбцов? ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Сколько строк? ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Глубина? ");
    int deep = Convert.ToInt32(Console.ReadLine());
    int[,,] array = new int[rows, cols, deep];
    Console.Write("Минимальное значение: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Максимальное значение: ");
    int max = Convert.ToInt32(Console.ReadLine());

    if (max - min < rows * cols * deep) 
    {
        Console.WriteLine("Нельзя заполнить без повторений!");
    }
    else
    {
        for (int x = 0; x < array.GetLength(0); x++)
        {
            for (int y = 0; y < array.GetLength(1); y++)
            {
                for (int z = 0; z < array.GetLength(2); z++)
                {
                    bool noRepeat;
                    int random = 0;
                    do
                    {
                        noRepeat = false;
                        random = new Random().Next(min, max);
                        foreach (var item in array)
                        {
                            if (item == random) noRepeat = true;
                        }
                    } while (noRepeat);

                    array[x, y, z] = random;
                }
            }
        }
    }

    return array;
}

void Print3DArray(int[,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.WriteLine($"array[{x}, {y}, {z}] = {array[x, y, z]}");
            }
        }
    }
}

int[,,] userArray = Get3DArray();
Print3DArray(userArray);