// Задача64
int n = 10;

Console.Write($"{PrintNums(n, 1)}");

string PrintNums(int left, int right)
{
    if (left <= right)
       return left.ToString();
    return $"{left} {PrintNums(left - 1, right)}";  
}