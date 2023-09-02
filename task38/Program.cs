/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

Console.Clear();

double[] GetDoubleArray(int length, int min, int max)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        //array[i] = new Random().NextDouble(min, max);
        array[i] = Math.Round((new Random().NextDouble() * (max - min) + min), 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}

double GetMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double GetMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double[] arr = GetDoubleArray(5, 0, 100);
double max = GetMax(arr);
double min = GetMin(arr);
PrintArray(arr);
Console.Write($" -> {max} - {min} = {max - min}");