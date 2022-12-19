// Задача 60

int[, ,] a = new int[2, 2, 2];

int[] nums = new int[90];
for (int i = 0; i < 90; i++)
    nums[i] = i + 10;


for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        for (int c = 0; c < a.GetLength(2); c++)
        {
            int temp = new Random().Next(90);
            while (nums[temp] == 0)
                temp = new Random().Next(90);

            a[i, j, c] = nums[temp];
            nums[temp] = 0;
        }
    }
}

for (int i = 0; i < a.GetLength(0); i++)
    for (int j = 0; j < a.GetLength(1); j++)
    {
        for (int c = 0; c < a.GetLength(2); c++)
            Console.Write($"{a[i, j, c]}({i}, {j}, {c}) ");
        Console.WriteLine();
    }        
        
    

