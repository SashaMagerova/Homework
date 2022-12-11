// Задача27

int A;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out A);

int b = A;
int sum = 0;

while (b > 0)
{
    sum = sum + b % 10;
    b = b / 10;
}
Console.Write($"{A} --> {sum}");
