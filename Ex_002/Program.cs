// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

int InpitNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int cols)
{
    return new int[rows, cols];
}

void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

void FindUndPrintPos(int[,] array, int r, int c)
{
    if (r >= array.GetLength(0) && c >= array.GetLength(1))
        Console.WriteLine($"{r},{c} - таких позиций в массиве нет.");
    else if (r == 0 && c == 0)
        Console.WriteLine($"{r},{c} - таких позиций в массиве нет.");
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == r - 1 && j == c - 1)
                Console.WriteLine($"Элемент на позициях {r},{c} - {array[i, j]}");
        }
}

int rows = InpitNum("Введите количество строк: ");
int cols = InpitNum("Введите количество столбцов: ");
int minVal = InpitNum("Введите минимальное значение диапазона: ");
int maxVal = InpitNum("Введите максимальное значение диапазона: ");
int[,] myArray = Create2DArray(rows, cols);
Fill2DArray(myArray, minVal, maxVal);
Print2DArray(myArray);
int row = InpitNum("Введите номер строки: ");
int col = InpitNum("Введите номер столбца: ");
FindUndPrintPos(myArray, row, col);
