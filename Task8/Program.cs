Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int k = 1;
while (k <= N)
{
    if (k % 2 == 0)
        if (k + 1 < N)
        Console.Write($"{k}, ");
        else
        Console.WriteLine($"{k}");
    k += 1;
}


