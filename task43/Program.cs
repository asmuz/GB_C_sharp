/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();


Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

/*
Упростим (решим) уравнение, для получения координат:
y = k1 * x + b1, y = k2 * x + b2
k1 * x + b1 = k2 * x + b2 (переносим влево значения с Х и выносим Х за скобки)
(k1 - k2) * x = b2 - b1 (делим обе части на (k1 - k2))
x = (b2 - b1) / (k1 - k2)
y = k1 * x + b1
*/

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения прямых находится в координатах: x={x}; y={y}]");