int[] x;
x = new int[10];
x[2]= 50;

foreach(int i in x)
{
    Console.WriteLine($"value = {i}");
}

for (int i = 0; i < x.Length; i++)
{
    Console.WriteLine($"i = {i}, value = {x[i]}");
}
