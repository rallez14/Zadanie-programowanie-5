// Zadanie 5

int x, n;
bool isValidInput = false;

do
{
    Console.Write("Podaj liczbę naturalną x: ");
    if (int.TryParse(Console.ReadLine(), out x) && x > 0)
    {
        isValidInput = true;
    }
    else
    {
        Console.WriteLine("Błędne dane! Podaj liczbę naturalną.");
    }
} while (!isValidInput);

isValidInput = false;

do
{
    Console.Write("Podaj liczbę całkowitą nieujemną n: ");
    if (int.TryParse(Console.ReadLine(), out n) && n >= 0)
    {
        isValidInput = true;
    }
    else
    {
        Console.WriteLine("Błędne dane! Podaj liczbę całkowitą nieujemną.");
    }
} while (!isValidInput);

int result = 1;

for (int i = 0; i < n; i++)
{
    int temp = result;
    for (int j = 1; j < x; j++)
    {
        result += temp;
    }
}

Console.WriteLine("Wynik obliczeń: " + result);

int expectedResult = (int)Math.Pow(x, n);
Console.WriteLine("Wynik prawidłowy: " + expectedResult);

if (result == expectedResult)
{
    Console.WriteLine("Wyniki są zgodne.");
}
else
{
    Console.WriteLine("Wyniki nie są zgodne.");
}