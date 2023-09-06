/* Задача 62: Заполните спирально массив 4 на 4. или (n на n) */


Console.Clear();

System.Console.Write("Высота массива:");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ширина массива:");
int cols = Convert.ToInt32(Console.ReadLine());

Console.Clear();

int[,] array = Spiral(rows, cols);

int[,] Spiral(int rows, int cols)
{
    int[,] array = new int[rows, cols];             // создаем пустой массив заданного размера
    int end = rows * cols;                          // до какого числа заполняем спираль
    int right = cols - 1;                           // правая граница
    int bottom = rows - 1;                          // нижняя граница
    int left = 0;                                   // левая граница
    int top = 1;                                    // верхняя граница
    int direction = 1;                              // начальное направление спирали (1 - вправо, 2 - вниз, 3 - влево, 4 - вверх)
    int y = 0;                                      // начальные координаты спирали
    int x = 0;
    int pause = 500;                                // велечина паузы (мс)

    for (int i = 1; i <= end; i++)
    {
        array[y, x] = i;                            // заполняем ячейку
        PrintCurrent(array, y, x);                  // отрисовываем текущее состояние массива
        Thread.Sleep(pause);                        // задержка перед следующей итерацией

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
            top++;                                  // сдвигаем верхнюю границу
            x++;                                    // и текущую позицию
        }
    }
    return array;
}

void PrintCurrent(int[,] array, int y, int x)                   // передаем массив и координаты текущего значения
{
    Console.SetCursorPosition(0, 0);                            // ставим курсор в начальную позицию
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == x && i == y)                               // рисуем текущую позицию красным цветом
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.Write(array[i, j] + "\t");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (array[i, j] != 0)                          // уже отрисованные позиции желтым
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.Write(array[i, j] + "\t");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else                                                // пустые (нулевые) черным
            {
                Console.ForegroundColor = ConsoleColor.Black;
                System.Console.Write(array[i, j] + "\t");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
        System.Console.WriteLine();
    }
}