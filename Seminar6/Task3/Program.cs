//Разворот массива

void InputArray(int[] array) // метод для заполнения массива
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11); // [1, 10]
}

void ReleaseArray(int[] array) // метод для замены элементов в массиве
{
    for (int i = 0; i < array.Length / 2; i++) // цикл, 1 элемент масива начинается с 0, пока i меньше длинны массива деленно на 2 выполнять цикл, 
    {
        int temp = array[i]; // создаем времнную пересенную temp и кладем в нее значение элемента масива
        array[i] = array[array.Length - 1 - i];// значение длинны массива - 1 - i кладем в левую коробку
        array[array.Length - 1 - i] = temp;
    }
}

Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");