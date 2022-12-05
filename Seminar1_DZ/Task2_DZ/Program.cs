// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число: ");
int s = Convert.ToInt32(Console.ReadLine());

if (n > m)
Console.WriteLine($"Max: {n}");
else if (m > s)
Console.WriteLine($"Max: {m}");
else
Console.WriteLine($"Max: {s}");