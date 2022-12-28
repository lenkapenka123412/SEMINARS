/* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник 
с сторонами такой длины.*/

Console.Clear();
Console.WriteLine("Введите три числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if(a < b + c && b < a + c && c < a + c) // теорема о неравнестве треугольников
Console.WriteLine("Треугольник");
else
Console.WriteLine("Нет");
