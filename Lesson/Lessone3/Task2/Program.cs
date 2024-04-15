void PrintSquares (int limit)
{
    int i = 1;
    while (i <= limit)
    {
        Console.Write($"{i*i} ");
        // i = i + 1;
        i++;
    }
}

PrintSquares(5);
PrintSquares(10);
PrintSquares(15);