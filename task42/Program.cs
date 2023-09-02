/* Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

Console.Clear();

Console.Write("Введите десятичное число: ");
int dexNumber = Convert.ToInt32(Console.ReadLine());

string ToBinary(int number)
{
    string result = String.Empty;
    int temp = 0;
    for (int i = number; i > 0; i /= 2)
    {
        temp = i % 2;
        result = temp + result;
    }
    return result;
}

Console.WriteLine(ToBinary(dexNumber));