//  Программа, которая принимает 
//  на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int EnterNumber()
{
    int number;
    while (true)
    {
        Console.Write("Введите трехзначное число: ");
        int.TryParse(Console.ReadLine(), out number);
        if (99 < number && number < 1000) break;
        else Console.WriteLine("Ошибка ввода!");
    }
    return number;
}

int num = EnterNumber();
int a1 = num % 100;
int a2 = a1 / 10;
Console.WriteLine($"Число {num} -> {a2}");