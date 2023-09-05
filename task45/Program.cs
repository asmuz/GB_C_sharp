/* 45. Напишите программу, которая будет создавать копию заданного одномерного массива
с помощью поэлементного копирования.*/

Console.Clear();

int[] MyArray()
{
    Console.Write("Укажите длинну массива: ");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Элемент {i} из {length - 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array )
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
    }
    Console.Write("]");
}

int[] CopyArray(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i];
    }
    return result;
}

int[] arr = MyArray();
int[] copy = CopyArray(arr);
PrintArray(copy);