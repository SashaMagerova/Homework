// Задача 54

int[,] array = new int[3,4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int s = 0; s < array.GetLength(0); s++)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int k = array[s, i];
        int j = i - 1;

        while (j >= 0 && array[s, j] > k)
        {
            array [s, j + 1] = array [s, j];
            array [s, j] = k;
            j--;
        }
    }
}



for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j]} ");
        Console.WriteLine();
}

