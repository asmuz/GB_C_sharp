/* Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины. */

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

bool TriangleExist(int[] array)
{
    if (array.Length != 3)
    {
        Console.WriteLine("Невозможно посчитать треугольник. В массиве должно быть ровно 3 элемента!");
        return false;
    }

    if (array[0] < array[1] + array[2]
    && array[1] < array[0] + array[2]
    && array[2] < array[0] + array[1])
    {
        return true;
    }

    else return false;

}

Console.Write(TriangleExist(MyArray()));