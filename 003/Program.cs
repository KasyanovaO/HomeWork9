/*/Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9//(29 при m=3, n=2)/*/

Console.WriteLine("Введите неотрицательное число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число m");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M={m}, N={n}");
Console.WriteLine("Вычисление функции Аккермана");
Console.WriteLine($"{A(m, n)}");
int A(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return A(m - 1, 1);
    else return A(m - 1, A(m, n - 1));
}






