/* Задача 58: Задайте две матрицы. Напишите программу, которая будет 
находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

void InputMatrix(int[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11); 
    }
}

void PrintMatrix(int[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

int[,] MultiplyMatrix(int[,] Matrix1, int[,] Matrix2)
{
    int[,] result = new int[Matrix1.GetLength(0), Matrix1.GetLength(1)];
    for (int i = 0; i < Matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix1.GetLength(1); j++)
        {
            result[i, j] = Matrix1[i, j] * Matrix2[i, j];
            Console.WriteLine($"{Matrix1[i, j]} x {Matrix2[i, j]} = {Matrix1[i, j] * Matrix2[i, j]}");
        }
        Console.WriteLine();
    }
    return result;
}

Console.Clear();
Console.Write("Введите размер матриц: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

while (size[0] != size[1])
{
    Console.Write("Вы ошиблись!\nВведите корректные данные для построения матрицы: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}

int[,] Matrix1 = new int[size[0], size[1]];
int[,] Matrix2 = new int[size[0], size[1]];

InputMatrix(Matrix1);
InputMatrix(Matrix2);
Console.WriteLine("Начальный массив 1: ");
PrintMatrix(Matrix1);
Console.WriteLine("Начальный массив 2: ");
PrintMatrix(Matrix2);
Console.WriteLine("Результат:");
PrintMatrix(MultiplyMatrix(Matrix1, Matrix2));