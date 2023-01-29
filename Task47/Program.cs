/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int getUserData (string message)
{
    Console.WriteLine (message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}


double [,] Create2DRandomArray (int rowLength, int colLength, int start, int finish)
{
    double[,] array = new double [rowLength, colLength];
    int divider = 100;
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            array [i,j] = new Random().Next (start*divider, (finish+1)*divider) / (divider+0.0);
        }
    }
    return array;
}

void PrintInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(data);
    Console.ResetColor();
}


void Print2DArray(double[,] array)
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

int m = getUserData ("Введите количество строк");
int n = getUserData ("Введите количество столбцов");
double[,] array = Create2DRandomArray (m,n,0,100);
Print2DArray (array);