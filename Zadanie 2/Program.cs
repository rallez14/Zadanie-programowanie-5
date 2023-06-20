// Zadanie 2

Console.WriteLine("Wersja 1");
Random random = new Random();
int drawCount = 0, evenNumbersCount = 10;
for (int i = 0; i < evenNumbersCount; i++)
{
    int drawnNumber;
    do
    {
        drawnNumber = random.Next(-8, 9);
        drawCount++;
    } while (drawnNumber % 2 != 0);

    Console.Write(drawnNumber);
    if (i < evenNumbersCount - 1)
    {
        Console.Write(", ");
    }
}

Console.WriteLine();
Console.WriteLine($"Liczba losowań: {drawCount}");
Console.WriteLine();

Console.WriteLine("Wersja 2");
drawCount = 0;
for (int i = 0; i < evenNumbersCount; i++)
{
    int drawnNumber = random.Next(-4, 5) * 2;
    drawCount++;
    
    Console.Write(drawnNumber);
    if (i < evenNumbersCount - 1)
    {
        Console.Write(", ");
    }
}

Console.WriteLine();
Console.WriteLine($"Liczba losowań: {drawCount}");