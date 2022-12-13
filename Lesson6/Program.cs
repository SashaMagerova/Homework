// Задача41

string[] numbers = Console.ReadLine()!.Split(' ');
int[] array = new int[numbers.Length];

for(int i = 0; i < numbers.Length; i++)
    {
        int.TryParse(numbers[i], out array[i]);
        Console.Write($"{array[i]} ");
    }

int n = 0;
foreach(var i in array)
    if (i > 0)
        n++;

Console.Write($"\n{n} чисел больше 0");

