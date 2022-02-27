// See https://aka.ms/new-console-template for more information
string s = Console.ReadLine();

if (s == "primo")
{
    Console.WriteLine("Hai scritto primo");
}
else if (s == "secondo")
{
    Console.WriteLine("Hai scritto secondo");
}
else
{
    Console.WriteLine($"Hai scritto {s}");
}

switch (s)
{
    case "primo":
        Console.WriteLine("Hai scritto primo");
        break;

    case "secondo":
        Console.WriteLine("Hai scritto secondo");
        break;

    default:
        Console.WriteLine($"Hai scritto {s}");
        break;
}

int x = 20;

switch (x)
{
    case int n when (n >= 10 && n <= 20):
        Console.WriteLine("Yes");
        break;

    default:
        Console.WriteLine("No");
        break;
}
