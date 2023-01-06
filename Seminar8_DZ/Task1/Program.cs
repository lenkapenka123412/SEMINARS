/* 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
 строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 
*/

void InputMatrix(int[,] matrix) // заполнение двумерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10); // рандомные числа от 1 до 9
        }
    }
}

void PrintMatrix(int[,] matrix) // печать начального массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)

            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

int[,] ReplacementMatrix(int[,] matrix) // функция для упорядочивания элементов массива по убыванию
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int maxNamber = j;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] > matrix[i, maxNamber]) maxNamber = k;

            }
            int m = matrix[i, j];
            matrix[i, j] = matrix[i, maxNamber];
            matrix[i, maxNamber] = m;

            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    return matrix;
}

Console.Clear();
Console.Write("Задайте размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine();

Console.WriteLine("Начальный массив:");
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

Console.WriteLine("Результат упорядочивания по убыванию: ");
ReplacementMatrix(matrix);