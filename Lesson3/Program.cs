// Задача21

int xa, xb, ya, yb, za, zb;
Console.Write($"Введите координату X точки А: ");
int.TryParse(Console.ReadLine()!, out xa);
Console.Write($"Введите координату Y точки А: ");
int.TryParse(Console.ReadLine()!, out ya);
Console.Write($"Введите координату Z точки А: ");
int.TryParse(Console.ReadLine()!, out za);
Console.Write($"Введите координату X точки B: ");
int.TryParse(Console.ReadLine()!, out xb);
Console.Write($"Введите координату Y точки B: ");
int.TryParse(Console.ReadLine()!, out yb);
Console.Write($"Введите координату Z точки B: ");
int.TryParse(Console.ReadLine()!, out zb);

double res = Math.Sqrt((xa-xb)*(xa-xb)+(ya-yb)*(ya-yb)+(za-zb)*(za-zb));
Console.Write($"Расстояние между точками A и B = {res}");

