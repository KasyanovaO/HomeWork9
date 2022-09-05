/*/Задача 2. Семинар. Напишите программу, которая на вход принимает два числа A и B,  
и возводит число А в целую степень B с помощью рекурсии./*/

Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A={A}, B={B}");
Console.WriteLine("Число A в степени B =");
Console.WriteLine($"{rec(A, B)}");
int rec(int A, int B)
{
    if (B == 0) return 1;
    if (B == 1) return A;
    else
        return A * rec(A, B - 1);
}

