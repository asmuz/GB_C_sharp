/* Задача 62: Заполните спирально массив 4 на 4. или (n на n) */


Console.Clear();

System.Console.Write("Высота массива:");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ширина массива:");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = Spiral(rows, cols);
Print2DArray(array);

int[,] Spiral(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    int end = rows * cols;  // до какого числа заполняем спираль
    int count = 1;          // начальное значение спирали
    int right = cols - 1;   // правая граница
    int bottom = rows - 1;  // нижняя граница
    int left = 0;           // левая граница
    int top = 1;            // верхняя граница
    int direction = 1;      // начальное направление спирали (1 - вправо, 2 - вниз, 3 - влево, 4 - вверх)
    int y = 0;              // начальные координаты спирали
    int x = 0;

    while (count <= end)
    {
        array[y, x] = count;                        // заполняем ячейку

        if (direction == 1 && x < right) x++;       // идём право, пока не упрёмся в границу
        else if (direction == 1 && x == right)      // если упёрлись в правую границу
        {
            direction = 2;                          // меняем направление вниз
            right--;                                // и сдвигаем правую границу
        }
        if (direction == 2 && y < bottom) y++;      // идём вниз, пока не упрёмся в границу
        else if (direction == 2 && y == bottom)     // если упёрлись в нижнюю границу
        {
            direction = 3;                          // меняем направление налево
            bottom--;                               // и сдвигаем нижнюю границу
        }
        if (direction == 3 && x > left) x--;        // идём влево, пока не упрёмся в границу
        else if (direction == 3 && x == left)       // если упёрлись в левую границу
        {
            direction = 4;                          // меняем направление вверх
            left++;                                 // и сдвигаем левую границу
        }
        if (direction == 4 && y > top) y--;         // идём вверх, пока не упрёмся в границу
        else if (direction == 4 && y == top)        // если упёрлись в верхнюю границу
        {
            direction = 1;                          // меняем направление вправо
            top++;                                  // и сдвигаем верхнюю границу,
            x++;                                    // а так же текущую позицию
        }
        count++;                                    // увелививаем счетчик
    }
    return array;
}

void Print2DArray(int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write(arrayToPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}