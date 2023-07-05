// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int InpitNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[,] Create2DArray(int rows, int cols)
{
    return new double[rows, cols];
}

void Fill2DArray(double[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = ((Math.Round(rnd.NextDouble(), 1)) + rnd.Next(min, max));
}

void Print2DArray(double[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
     {
        for (int j = 0; j < array.GetLength(0); j++)
            Console.Write($"{array[i,j]}\t");
        Console.WriteLine();
     }
}

int rows = InpitNum("Введите количество строк: ");
int cols = InpitNum("Введите количество столбцов: ");
int minVal = InpitNum("Введите минимальное значение диапазона: ");
int maxVal = InpitNum("Введите максимальное значение диапазона: ");
double[,] myArray = Create2DArray(rows, cols);
Fill2DArray(myArray, minVal, maxVal);
Print2DArray(myArray);