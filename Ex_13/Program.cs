// Программа, которая выводит третью 
// цифру заданного числа (включая отрицательные) или сообщает, что третьей цифры нет.

int EnterNumber()
{
    int number;
    while (true)
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out number)) break;
        else Console.WriteLine("Ошибка ввода!");
    }
    return number;
}
int num = EnterNumber();
int result = Math.Abs(num);
if (result < 100)
{
    Console.WriteLine($"{num} ->  третьей цифры нет");
}
else
{
    while (result > 1000)
    {
        result = result / 10;
    }
    result = result % 10;
    Console.WriteLine($"{num} ->{result}");
}