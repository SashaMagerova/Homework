// Задача38

double[] array = new double[6];

for (int i = 0; i < array.Length; i++)
     array [i] = new Random().Next(1,100);     
Print(array);

double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++)
    if (array[i] > max)
         max = array[i];
    else if (array[i] < min)
          min = array[i];
Console.Write($"{max} - {min} = {max - min} ");


void Print(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
         Console.Write($"{arr[i]} ");
    Console.WriteLine();
}
