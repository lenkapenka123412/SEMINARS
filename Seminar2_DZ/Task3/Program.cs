/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

// Task3
Console.Clear();
Console.Write("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while(n < 1 || n > 7)
    {
        Console.Write("Вы ошиблись!\n");
        n = Convert.ToInt32(Console.ReadLine());
    }
if(n == 1 || n <= 5)
    {  
        Console.Write("Будний день, иди на работу(((");
    }
else
    Console.WriteLine("Ура! выходной!!!");
    

    