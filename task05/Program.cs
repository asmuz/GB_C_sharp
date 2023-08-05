// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Clear();

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = -1 * number;

for (int i = index; i <= number; i++)
{
    Console.Write(i + " ");
}