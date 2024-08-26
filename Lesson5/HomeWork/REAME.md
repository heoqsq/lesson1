# Домашнее задание

* Добавить в код отладочный вывод, который позволит увидеть "раскручивание" рекурсии, то есть процесс возвратов к местам рекурсивного вызова функции на строке 9
```sh
int Fact(int n)
{
    if(n == 1)
    {
        Console.WriteLine($"Stop requrson: n={n}");
        return 1;
    }
    Console.WriteLine(n);
    return n * Fact(n - 1);
}

Console.WriteLine(Fact(5));