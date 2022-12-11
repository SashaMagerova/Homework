// Задача23

int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

int i;
for (i = 1; i <= N; i++)
     Console.Write($"{i * i * i} ");

