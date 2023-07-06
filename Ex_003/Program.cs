/*

Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


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
            array[i,j] = rnd.Next(min, max+1);
}

void Print2DArray(int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
     {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]}\t");
        Console.WriteLine($"\t");
     }
}

void AverageInColumns(int[,] array)
{
    Console.WriteLine("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {

            sum += array[i,j];
        }
        double avrg = Math.Round((sum / array.GetLength(0)), 2);
        Console.Write($"{avrg};\t");
    }
}

int rows = InpitNum("Введите количество строк: ");
int cols = InpitNum("Введите количество столбцов: ");
int minVal = InpitNum("Введите минимальное значение диапазона: ");
int maxVal = InpitNum("Введите максимальное значение диапазона: ");
int[,] myArray = Create2DArray(rows, cols);
Fill2DArray(myArray, minVal, maxVal);
Print2DArray(myArray);
AverageInColumns(myArray);