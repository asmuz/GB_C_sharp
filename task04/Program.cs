/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Clear();

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (number1 > number2) {max = number1;}
else {max = number2;}

if (max > number3) {Console.WriteLine("Максимальное число из " + number1 + ", " + number2 + " и " + number3 + " это " + max);}
else {Console.WriteLine("Максимальное число из " + number1 + ", " + number2 + " и " + number3 + " это " + number3);}