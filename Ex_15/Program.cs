//  Программа, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
int EnterNumber()
{
    int number;
    while (true)
    {
        Console.Write("Введите номер дня недели: ");
        if (int.TryParse(Console.ReadLine(), out number) && number > 0 && number < 8)
        {
            break;
        }
        else Console.WriteLine("Ошибка ввода!");
    }
    return number;
}
int num = EnterNumber();
if (num == 6)
{
    Console.WriteLine($"{num} -> выходной");
}
else if (num == 7)
{
    Console.WriteLine($"{num} -> выходной");
}
else
{
    Console.WriteLine($"{num} -> не выходной");
}