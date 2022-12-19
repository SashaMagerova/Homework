// Задача66
int m = 1, n = 15;

Console.Write($"{Summ(m, n)}");

int Summ(int left, int right)
{
    if (left >= right)
       return left;
    return left + Summ(left + 1, right);   
}