/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] GetArray(int length, int min, int max) {
    int[] array = new int[length];
    for (int i = 0; i < length; i++) {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void PrintArray(int[] array) {
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) {
        Console.Write(array[i]);
        if(i < array.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}

Console.Clear();

Console.Write("Введите длинну массива: ");
int userArrayLenth = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение для элементов массива: ");
int userMin = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение для элементов массива: ");
int userMаx = Convert.ToInt32(Console.ReadLine());

int[] array = GetArray(userArrayLenth, userMin, userMаx);
PrintArray(array);