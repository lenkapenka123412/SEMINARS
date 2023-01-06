﻿/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int AkkermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1; 
    else if (n == 0 && m > 0)
        return AkkermanFunction(m - 1, 1);
    return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}
Console.Write("Число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A(m,n) = {AkkermanFunction(m, n)}");