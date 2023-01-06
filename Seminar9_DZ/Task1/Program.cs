/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int sum(int m, int n)
{
    if (m == n)
        return m;
    return sum(m, n - 1) + n;
}

Console.Clear();
Console.Write("Введите число M: ");
int namber1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int namber2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum(namber1, namber2));