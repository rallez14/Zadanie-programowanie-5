// Zadanie 4

int maxAttempts = 3;
int attemptCount = 0;
int rombSize = 0;

while (attemptCount < maxAttempts)
{
    Console.Write("Podaj rozmiar rombu (liczba nieparzysta >= 3): ");
    rombSize = Convert.ToInt32(Console.ReadLine());

    if (rombSize >= 3 && rombSize % 2 != 0)
    {
        break;
    }

    attemptCount++;
    Console.WriteLine("Nieprawidłowy rozmiar rombu. Spróbuj ponownie.");
    Console.WriteLine();
}

if (attemptCount == maxAttempts)
{
    Console.WriteLine("Przekroczono liczbę prób. Program zostanie zakończony.");
    return;
}

Random random = new Random();
char[] outer = { '#', '@', '|', '*' };
char[] inner = { '.', ':', '-', '+' };
char outerChar = outer[random.Next(0, outer.Length)];
char innerChar = inner[random.Next(0, inner.Length)];

int blankSpaces = rombSize / 2;
int chars = 1;

for (int i = 0; i < rombSize; i++)
{
    for (int j = 0; j < blankSpaces; j++)
    {
        Console.Write(" ");
    }

    for (int j = 0; j < chars; j++)
    {
        if (j == 0 || j == chars - 1 || i == 0 || i == rombSize - 1)
        {
            Console.Write(outerChar);
        }
        else
        {
            Console.Write(innerChar);
        }
    }

    Console.WriteLine();

    if (i < rombSize / 2)
    {
        blankSpaces--;
        chars += 2;
    }
    else
    {
        blankSpaces++;
        chars -= 2;
    }
}