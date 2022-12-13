// Задача43

double d1;
Console.WriteLine($"Введите значение d1: ");
double.TryParse(Console.ReadLine()!, out d1);

double k1;
Console.WriteLine($"Введите значение k1: ");
double.TryParse(Console.ReadLine()!, out k1);

double b2;
Console.WriteLine($"Введите значение b2: ");
double.TryParse(Console.ReadLine()!, out b2);

double k2;
Console.WriteLine($"Введите значение k2: ");
double.TryParse(Console.ReadLine()!, out k2);

if (k2 != k1)
{
    double x = (b2 - d1) / (k1 - k2);
    double y = k1 * x * d1;

    Console.Write($"{x};{y}");
}

else 
    Console.WriteLine($"Две прямые не пересекутся");
