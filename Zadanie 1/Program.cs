// Zadanie 1

int n;
Console.Write("n: ");
n = Convert.ToInt32(Console.ReadLine());
List<int> numbers = new List<int>();
for (int i = 2; true; i++)
{
    bool isPrime = true;
    if (numbers.Count == n || n < 1)
    {
        break;
    }
    for (int j = 2; j <= (int)Math.Floor(Math.Sqrt(i)); j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        numbers.Add(i);
    }
}

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"[{i + 1}] {numbers[i]}");
}