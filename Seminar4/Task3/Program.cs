// Работа с функциями
// Необходимо вывести наибольшее число из 2-х

char test(int a, int b=10)
{
if (a > b)
return '>';
return '<';
}

Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(test(n));
// 1. return
// * Возвращает аргумент туда, где была вызвана функция
// * Завершает работу функции
// * Возвращаемое значение необходимо принимать в консоль(вывод) или в переменную нужного типа данных
// * Сколько аргументов мы принимаем, столько и передаем