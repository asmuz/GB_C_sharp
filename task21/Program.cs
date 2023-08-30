/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();

Console.WriteLine("Введите координаты ПЕРВОГО числа (X1, Y1, Z1): ");
int X1 = Convert.ToInt32(Console.ReadLine());
int Y1 = Convert.ToInt32(Console.ReadLine());
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты ВТОРОГО числа (X2, Y2, Z2): ");
int X2 = Convert.ToInt32(Console.ReadLine());
int Y2 = Convert.ToInt32(Console.ReadLine());
int Z2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2));

Console.WriteLine("Расстояние между точками: " + Math.Round(distance, 2));