// Задача10

int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

int B;
B = N / 10;

int C;
C = B % 10;
Console.WriteLine($"{C}");


