// Zadanie 3

Console.Write("Podaj wysokość trójkąta: ");
int height = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < height - i - 1; j++)
    {
        Console.Write("  ");
    }

    for (int j = 0; j < i * 2 + 1; j++)
    {
        Console.Write("+ ");
    }

    Console.WriteLine();
}