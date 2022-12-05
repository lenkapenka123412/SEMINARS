/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

Console.Clear();
Console.Write("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
string m = Convert.ToString(n);
Console.WriteLine("вторая цифра этого числа -> "+m[1]);