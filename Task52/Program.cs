/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

void PrintInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(data);
    Console.ResetColor();
}

int[,] get2DIntArray(int rowLength, int colLength, int start, int end)
{
    int[,] array = new int[rowLength, colLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            array[i, j] = new Random().Next(start, end + 1);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    Console.Write(" \t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        PrintInColor(j + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        PrintInColor(i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

double GetAverageOfColumn (int [,] array, int column) 
{
    double sum = 0;
    double average = 0.0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + (double) array [j,column];
        }
        average = sum / array.GetLength(0);
    return average;
}

int [,] arr = get2DIntArray (5,5,0,10);
Print2DArray (arr);
Console.Write ("Среднее арифметическое столбцов массива равно: ");
for (int i = 0; i < arr.GetLength(1); i++)
{
    double average = GetAverageOfColumn (arr, i);
    Console.Write ($"{average} \t");
}
Console.WriteLine();