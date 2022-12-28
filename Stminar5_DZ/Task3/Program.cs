/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
и минимальным элементов массива.
*/

void DiffArray(double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    Console.WriteLine($"Max = {max}");

    double min = max;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    Console.WriteLine($"Min = {min}");
    Console.WriteLine($"Разница {max - min}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(new Random().NextDouble() * 10, 2); 
}
Console.WriteLine($"[{string.Join(", ", array)}]");

DiffArray(array);