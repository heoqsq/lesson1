for (int i = 1; i <=5; i++)
{
    Console.Write($"Iteration {i}: ");
    if (i == 3)
    {
        Console.WriteLine("Skip");
        continue;
    }
    Console.WriteLine("Some processing");
}