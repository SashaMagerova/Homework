// Задача 58

int[,] a = new int[2, 2] { { 2, 4 }, { 3, 2 } };
int[,] b = new int[2, 2] { { 3, 4 }, { 3, 3 } };
int[,] c = new int[a.GetLength(0), b.GetLength(1)];

for (int i = 0; i < c.GetLength(0); i++)
{
    for (int j = 0; j < c.GetLength(1); j++)
    {
        int sum = 0;
        for (int r = 0; r < a.GetLength(1); r++)
        {
           sum += a[i, r] * b[r, j];
        }
        c[i, j] = sum; 
    }
}



for (int i = 0; i < c.GetLength(0); i++)
{
    for (int j = 0; j < c.GetLength(1); j++)
        Console.Write($"{c[i, j]} ");
        Console.WriteLine();
} 

