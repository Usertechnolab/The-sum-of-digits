for (int number = 10; number <= 99; number++)
{
    if (((number / 10) + (number % 10)) > 14)
    {
        Console.WriteLine(number);
    }
}