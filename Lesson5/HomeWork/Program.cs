int Fact(int n)
{
    if (n == 1)
    {
        Console.WriteLine($"Stop reqursion:n={n}");
        return 1;
    }
    Console.WriteLine(n);
    int res = n * Fact(n - 1);
    Console.WriteLine($"Возврат:n={n}, fact={res / n}");
    return res;
}

Console.Write(Fact(5));