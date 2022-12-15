
Console.Clear();
Console.WriteLine("Введите числа: ");
int n = Convert.ToInt32(Console.ReadLine());

first_max = n;
second_max = n;

while( n != 0 )
{
    if(first_max < second_max)
    {
        first_max, second_max = second_max, first_max
    }
    n = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine("End");
   