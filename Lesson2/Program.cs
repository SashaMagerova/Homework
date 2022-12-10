// Задача13

int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

if (N < 100)
{
    Console.WriteLine($"Третьей цифры нет");
    return;
}
else 
{
    while (N >= 1000)
    {
        N = N /10;
    }
}

int C;
C = N % 10;
Console.WriteLine($"{C}");

