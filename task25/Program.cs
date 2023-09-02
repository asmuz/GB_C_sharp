/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int ExponentOfNumber(int number, int exponent)
{
    if (exponent < 0) exponent = exponent * -1;
    int result = 1;
    for (int i = 0; i < exponent; i++)
    {
        result = result * number;
    }
    return result;
}

Console.Clear();

Console.Write("Какое число возводим? ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("В какую степень? ");
int userExponent = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Результатом возведения числа {userNumber} в степень {userExponent} является число "
+ ExponentOfNumber(userNumber, userExponent));