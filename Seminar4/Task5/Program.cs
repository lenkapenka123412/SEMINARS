﻿//Задача 24

/* Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.*/ 

Console.Clear();
Console.Write("Введите число: ");
double n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((1 + n) / 2 * n);