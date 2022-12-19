// Работа с функциями
void test(ref int a)
{
    a += 5;
}
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
test(ref m);
Console.WriteLine(m);