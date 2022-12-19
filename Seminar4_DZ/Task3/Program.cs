/* Напишите программу, которая спрашивает у пользователя кол-во элементов и спршивает сами элементы. 
После записи элементов в массив, необходимо его вывести на экран.
8
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
*/

Console.Clear();
Console.WriteLine("Ввод массива: ");
int[] n = new int[8];
for(int i = 0; i < n.Length; i++)
{
    Console.Write($"{string.Join(", ", n)}: ");
    n[i] = int.Parse(Console.ReadLine());
}
Console.Write("Вывод массива: ->");
for(int i = 0; i < n.Length; i++)
{
    Console.WriteLine($"[{string.Join(", ", n)}]");
    break;
}
