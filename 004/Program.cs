//Задача 1. Семинар. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M={M}");
Console.WriteLine("Сумма цифр числа");
Console.WriteLine($"{rec(M)}");
int rec(int M)
{
    if (M < 10) return M;
    else
        return M % 10 + rec(M / 10);
}

