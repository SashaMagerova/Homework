// Задача47

double[,] array = new double[6,7];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        array[i, j] = Math.Round(new Random().NextDouble() * 19 - 9.9, 2);
        Console.Write($"{array[i, j]}" );
    }
    Console.WriteLine();
}
