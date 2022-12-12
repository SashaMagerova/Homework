// Задача36

int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
     array [i] = new Random().Next(-20,30);     
Print(array);

int sum = 0;
for (int i = 1; i < array.Length; i+=2)
     sum = sum + array[i];
Console.Write($"{sum}");


void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
         Console.Write($"{arr[i]} ");
    Console.WriteLine();
}
