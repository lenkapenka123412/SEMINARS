//Суперсдвиг

int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int k = Convert.ToInt32(Console.ReadLine());
int[] result = new int[numbers.Length];
k %= n;
if (k > 0)
{
for (int i = 0; i < k; i++)
result[i] = numbers[numbers.Length - k + i];
for (int i = 0; i < numbers.Length - k; i++)
result[k + i] = numbers[i];
Console.WriteLine($"{string.Join(" ", result)}");
}
else
{
k = k * (-1);
for (int i = 0; i < k; i++)
result[numbers.Length - k + i] = numbers[i];
for (int i = 0; i < numbers.Length - k; i++)
result[i] = numbers[k + i];
Console.WriteLine($"{string.Join(" ", result)}");
}