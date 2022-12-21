//Задача 47.
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
/*
double[,] CreateRandom2DArrayDouble()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round( new Random().Next(min, max + 1) + random.NextDouble(), 1);
        }
    }
    return array;
}
void Show2dArrayDouble(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == 0)
                        Console.Write($"[ {array[i, j]} | ");
                    else if (j == array.GetLength(1) - 1)
                        Console.WriteLine($"{array[i, j]} ]");
                    else
                        Console.Write($"{array[i, j]} | ");
                }
            }
        }

double[,] array = CreateRandom2DArrayDouble();
Show2dArrayDouble(array);
*/

//Задача 50.
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7->такого числа в массиве нет
/*
int[,] CreateRandom2DArrayInt()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void Show2dArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0)
                Console.Write($"[ {array[i, j]} ");
            else if (j == array.GetLength(1) - 1)
                Console.WriteLine($"{array[i, j]} ]");
            else
                Console.Write($"{array[i, j]} ");
        }
    }
}

void GetPositionArray(int[,] array, int row, int column)
{
    if (row <= array.GetLength(0) && column <= array.GetLength(1))
        Console.WriteLine($"Number in array: {array[row - 1, column - 1]}");
    else
        Console.WriteLine("There is no such number in the array.");
}
int[,] array = CreateRandom2DArrayInt();
Show2dArrayInt(array); 
Console.WriteLine("To find a number, enter it's index.");
Console.Write("Input a index of row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a index of column: ");
int column = Convert.ToInt32(Console.ReadLine());
GetPositionArray(array, row, column);
*/

//Задача 52.
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
int[,] CreateRandom2DArrayInt()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void Show2dArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0)
                Console.Write($"[ {array[i, j]} ");
            else if (j == array.GetLength(1) - 1)
                Console.WriteLine($"{array[i, j]} ]");
            else
                Console.Write($"{array[i, j]} ");
        }
    }
}
void PrintArrayDouble(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
            Console.Write($"[ {array[i]} | ");
        else if (i == array.Length - 1)
            Console.WriteLine($"{array[i]} ]");
        else
            Console.Write($"{array[i]} | ");
    }
}

void Avarage(int[,] array)
{
    double[] columns = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
        for (int j = 0; j < array.GetLength(0); j++)
        {
            columns[i] += array[j, i];
            if (j == array.GetLength(0) - 1)
            {
                columns[i] = Math.Round(columns[i] / array.GetLength(0), 1);
            }
        }

    Console.Write($"Arithmetic mean of each column: ");
    PrintArrayDouble(columns);
}
int[,] array = CreateRandom2DArrayInt();
Show2dArrayInt(array);
Avarage(array);
*/