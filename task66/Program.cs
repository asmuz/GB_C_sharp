﻿/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear();

int SumMN(int numM, int numN)
{
    if (numM != numN) return numM + SumMN(numM + 1, numN);
    else return numM;
}

Console.Write("ОТ (M): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("ДО (N): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от {m} до {n} равна {SumMN(m, n)}");