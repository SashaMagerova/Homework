// Задача68
int m = 2, n = 3;

Console.Write($"{Accerman(m, n)}");

int Accerman(int m, int n)
{
    if (m == 0)
       return n + 1;
    else if (n == 0)
       return Accerman(m - 1, 1);
    else 
       return Accerman(m - 1, Accerman(m, n - 1));
}

