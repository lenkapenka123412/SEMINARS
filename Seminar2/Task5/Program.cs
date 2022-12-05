Console.Clear();

Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n * n == m || m * m == n) 
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");