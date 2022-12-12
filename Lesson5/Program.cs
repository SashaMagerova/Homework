// Задача34

int[] array = new int[4];

for (int i = 0; i < array.Length; i++)
     array [i] = new Random().Next(100,1000);     
Print(array);

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
       sum +=1; 
    }
}
Console.Write($"--> {sum} ");


void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
         Console.Write($"{arr[i]} ");
    Console.WriteLine();
}
