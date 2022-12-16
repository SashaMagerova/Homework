// Задача50

int[,] array = new int[3,3];
int n = 9;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} " );
    }
    Console.WriteLine();
}

bool find = false;

foreach(var i in array)
    if (i == n) {find = true; break; }  

if (find)
    Console.Write($"Число присутствует в массиве");
else
    Console.Write($"Такого числа нет");