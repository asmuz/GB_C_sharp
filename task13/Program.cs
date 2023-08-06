/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Clear();

Console.WriteLine("Введите число:");
int user = Convert.ToInt32(Console.ReadLine());
int number = user; //сохраняем введенное число для вывода в строках 20 и 22 и работаем с копией

if (number > 99) {
    while (number > 999) {
        number = number / 10;
        //Console.WriteLine(number);
    }
    int result = number % 10;
    Console.WriteLine($"Третьей цифрой числа {user} является {result}");
}
else Console.WriteLine($"У числа {user} нету третьей цифры");