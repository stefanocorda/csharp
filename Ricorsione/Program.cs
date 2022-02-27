Console.WriteLine("----------------------------------------------------- ");
Console.Write("Inserisco un numero intero uguale o maggiore di zero: ");
string s = Console.ReadLine();

int n = Convert.ToInt32(s);

Console.WriteLine($"Il fattoriale di {n} è {Fattoriale(n)}");

static int Fattoriale(int n)
{
    if (n == 0)
    {
        return 1;
    } else {
        return n * Fattoriale(n-1);
    }
}
