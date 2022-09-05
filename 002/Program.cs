/*/Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30/*/

Console.WriteLine("Введите значение M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M={M}, N={N}");
Console.WriteLine("Сумма элементов от M до N");
Console.WriteLine($"{Sum(M, N)}");
int Sum(int M, int N)
{
    if (M == N)
        return N;
    return N + Sum(M, N - 1);
}























