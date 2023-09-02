/* Задача 19
Напишите программу, которая принимает на вход пятизначное (или ЛЮБОЕ ) число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();

Console.WriteLine("Введите ЛЮБОЕ число: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
int number = inputNumber;//делаем копию числа, с которой будем работать
int reverseNumber = 0;

// создаем "множитель" для дальнейшего "разворота числа"
int countNumber = inputNumber;//делаем копию исходного числа, для получения разрядности
int multiplier = 1;//множитель
while (countNumber > 0)
{
    multiplier *= 10;
    countNumber /= 10;
}
multiplier /= 10;//корректировка итогового множителя (нужно на 1 разряд мемньше)

while (number > 0)
{
    int lastNumber = number % 10;
    reverseNumber += lastNumber * multiplier;
    number /= 10;
    multiplier /= 10;
}

if (reverseNumber == inputNumber)
{
    Console.WriteLine("Круто! " + inputNumber + " это число ПОЛИНДРОМ!");
}

else
{
    Console.WriteLine("Число " + inputNumber + " и его развёрнутая версия " + reverseNumber + " отличаются");
}