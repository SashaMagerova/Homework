// Задача8

int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

int index = 2;

while (index <= N)
{
  if (index % 2 == 0);
      Console.Write($"{index} ");
      index += 2;
}      