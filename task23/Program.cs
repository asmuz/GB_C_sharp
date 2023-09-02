﻿﻿/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Clear();

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0) n *=-1;

Console.Clear();
Console.Write(n + " -> ");

int result = 0;
for (int i = 1; i <= n; i++) {
    Console.Write(Math.Pow(i, 3) + " ");
    }