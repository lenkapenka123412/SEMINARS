/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Clear();
Console.Write("Введите N чисел через пробел: ");
int[] nambers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int sumPositivNamber = 0;
foreach(int element in nambers)
{
    if(element > 0)
    sumPositivNamber++;
}
Console.WriteLine($"Сумма положительных чисел: {sumPositivNamber}");