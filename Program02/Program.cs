int FindMaxDigit(int number)
{
    int digit1 = number / 10;
    int digit2 = number % 10;
    if (digit1 > digit2)
        return digit1;
    else
        return digit2;
}


int randNumber = new Random().Next(10, 100);
int maxDigit = FindMaxDigit(randNumber);

Console.WriteLine($"Максимальная цифра числа {randNumber}: {maxDigit}");