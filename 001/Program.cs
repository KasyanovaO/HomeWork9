/*/Задача 64: Задайте значения M и N. Напишите программу, которая 
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""/*/


Console.WriteLine("Введите значение M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M={M}, N={N}");
Console.WriteLine("Натуральные  числа в промежутке от M до N");
Console.WriteLine($"{rec(M, N)}");
int rec(int M, int N)
{
    if (M == N) return M;
    else
        Console.Write($"{rec(M, N - 1)}, ");
    return N;
}







