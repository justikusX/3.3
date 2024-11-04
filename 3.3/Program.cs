try
{
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());

    Console.Write("Введите n:");
    int n = int.Parse(Console.ReadLine());

    double s = 0;

    int F = 1;

    for(int j = 1; j <= n; j += 1)
    {
        F = F * j;
    }
    Console.WriteLine($"Factorial = {F}");
    for (int i = 1; i <= n; i += 1)
    {
        s += x - (Math.Pow(x, i) / F);
    }
    Console.WriteLine($"s = {s:F2}");
        
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}