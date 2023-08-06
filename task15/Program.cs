/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Clear();

Console.WriteLine("Введите число от 1 до 7 (типа день недели):");
int day = Convert.ToInt32(Console.ReadLine());

if (day >= 1 && day <= 7) {
    if (day == 6 || day == 7) Console.WriteLine("Выходной!");
    else Console.WriteLine("Опять на работу...");
}
else Console.WriteLine("Вы что! У нас 7 дней в неделе!");