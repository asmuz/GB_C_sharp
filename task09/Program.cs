/*
Написать программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
456 -> 46
782 -> 72
918 -> 98
*/

Console.Clear();

int random = new Random().Next(100, 1000);
Console.WriteLine("Загаданное число: " + random);

int number1 = random / 100;
int number2 = random % 10;

int result = number1 * 10 + number2;
Console.WriteLine("Получившееся число: " + result);