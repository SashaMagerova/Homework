// Задача15

/* int N;
Console.Write($"Введите цифру: ");
int.TryParse(Console.ReadLine()!, out N);

if (N > 5)
{
    Console.WriteLine($"да");
}
else
{
    Console.WriteLine($"нет");
} */

int N;
Console.Write($"Введите цифру: ");
int.TryParse(Console.ReadLine()!, out N);

if (N % 6 == 0 || N % 7 == 0 )
{
    Console.WriteLine($"да");
}
else
{
    Console.WriteLine($"нет");
}