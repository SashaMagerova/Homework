// Задача2

int a, b;

Console.Write($"Введите первое число: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите второе число: ");
int.TryParse(Console.ReadLine()!, out b);

if (a > b)
{
  Console.Write($"{a}");  
}
else
{
   Console.Write($"{b}"); 
}