// Задача25

int A, B;
Console.Write($"Введите число A: ");
int.TryParse(Console.ReadLine()!, out A);
Console.Write($"Введите число B: ");
int.TryParse(Console.ReadLine()!, out B);

if (B == 0)
    Console.Write(1);

else
{
    int res = 1;
    for (int i = 0; i < B; i++)
         res *= A;
         Console.Write(res);
}

