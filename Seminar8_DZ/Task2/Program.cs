/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
суммой элементов: 1 строка*/

void InputMatrix(int[,] matrix) // Заполняем массив
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10); // генерация рандомных чисел
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void SumElementMatrix(int[,] matrix)
{
    int m = 0;
    int minsum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            sum += matrix[i, j]; // подсчет элементов строки
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}"); 
        if (i == 0) 
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            m = i;
        }
    }
    Console.WriteLine($"{m + 1} строка с минимальной суммой элементов");
} 

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

while (size[0] == size[1])
{
    Console.Write("Вы ошиблись!\nВведите корректные данные для построения прямоугольной матрицы: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}

int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальный массив:");
InputMatrix(matrix);
Console.WriteLine("Сумма элементов каждой из сторк:");
SumElementMatrix(matrix);