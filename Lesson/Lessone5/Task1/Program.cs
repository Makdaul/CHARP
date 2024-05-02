int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        return 1;
    }
    System.Console.WriteLine(n);
    return n * Fact(n - 1);
}

System.Console.WriteLine(Fact(5));
