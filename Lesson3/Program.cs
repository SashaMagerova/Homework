// Задача19

int A;
Console.Write($"Введите 5ти значное число: ");
int.TryParse(Console.ReadLine()!, out A);


string A1 = A.ToString();

if ( A1[0] == A1[4] && A1[1] == A1[3])
    Console.WriteLine($"Да");

else 
    Console.WriteLine($"Нет"); 