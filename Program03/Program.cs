// Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.

/* int RemoveSecondDigit(int number)
{
    int digit1 = number / 100;
    int digit3 = number % 10;
    return digit1 * 10 + digit3;
}

int randNumber = new Random().Next(100, 1000);
int result = RemoveSecondDigit(randNumber);
Console.WriteLine($"Число без второй цифры числа {randNumber} это {result}");
 */


// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если второе число не кратно числу
// первому, то программа выводит остаток от деления.

void CheckMultiplier(int number1, int number2)
{
    int rest = number2 % number1;
    if (rest == 0)
    {
        Console.WriteLine($"Второе число {number2} кратно первому числу {number1}");
    }
    else
    {
        Console.WriteLine($"Второе число {number2} не кратно первому числу {number1}.");
        Console.WriteLine($"Остаток от деления равняется {rest}.");
    }
}

Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

CheckMultiplier(num1, num2);
