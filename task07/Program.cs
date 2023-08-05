// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Clear();

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int result = number % 10;
    Console.WriteLine("Последняя цифра числа " + number + " это " + result);
}
else Console.WriteLine("Вы ввели не трёхзначное число!");