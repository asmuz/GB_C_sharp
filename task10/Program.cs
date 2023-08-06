/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();

int random = new Random().Next(100, 1000);
Console.WriteLine("Загаданное число: " + random);

int result = (random / 10) % 10;

Console.WriteLine("Вторая цифра этого числа: " + result);