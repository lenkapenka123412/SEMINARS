// Двумерные массивы/ простой двумрный массив.

string[, ] table = new string[3, 5];
table[1, 2] = "слово";

for(int rows = 0; rows < 2; rows++ )
{
    for(int colums = 0; colums < 5; colums++)
    {
        Console.WriteLine($"{table[rows, colums]}");
    }
}