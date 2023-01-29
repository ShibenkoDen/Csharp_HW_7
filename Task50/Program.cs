/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
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

int FindPosition(int[,] array, int rowPosition, int colPosition)
{
    return array[rowPosition, colPosition];
}

int[,] arr = get2DIntArray(10, 10, -99, 99);
Print2DArray(arr);
int row = getUserData("Введите индекс строки искомого элемента");
int column = getUserData("Введите индекс столбца искомого элемента");
if (row >= 0 && row < arr.GetLength(0)
    && column >= 0 && column < arr.GetLength(1))
    {
        int result = FindPosition(arr, row, column);
        Console.WriteLine($"Число с индексами [{row},{column}] равно {result}");    
    }
else
{
        Console.WriteLine ($"Числа с индексами [{row},{column}] в массиве нет");
}
