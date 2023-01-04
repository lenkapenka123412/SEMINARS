/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такой позиции в массиве нет (пользователь вводит нумерацию с 1) */

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-999, 1000);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ElementPosition(int[,] matrix, int positionX, int positionY)
{
    if (matrix.GetLength(0) < positionY || matrix.GetLength(1) < positionX)
        Console.Write($"{positionX}, {positionY} - такой позиции в массиве нет");
    else Console.Write($"{positionX}, {positionY} = {matrix[positionY - 1, positionX - 1]}");
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);

Console.Write("какой элемент массива вывести: ");
int[] positionXY = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
ElementPosition(matrix, positionXY[0], positionXY[1]);