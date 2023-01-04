/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void AverageMatrix(int[,] matrix)
{
    double average = 0;
    Console.WriteLine("Среднее арифметическое каждого столбца: ");
    for (int row = 0; row < matrix.GetLength(1); row++)
    {
        average = 0;
        for (int colums = 0; colums < matrix.GetLength(0); colums++)
        {
            average = average + matrix[colums, row];
            if (matrix.GetLength(0) == colums + 1) Console.Write($"{average / matrix.GetLength(0)} \t");
        }
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
AverageMatrix(matrix);