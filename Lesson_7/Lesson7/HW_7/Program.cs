//* Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//! Использовать рекурсию, не использовать циклы.

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Введите число: ");
        int M = Convert.ToInt32(Console.ReadLine()!);
        System.Console.WriteLine("Введите второе число: ");
        int N = Convert.ToInt32(Console.ReadLine()!);
        Interval(M, N);
    }
    static int Interval(int M, int N)
    {
        if (M <= N)
            return;
        Interval(M++);
        System.Console.WriteLine(M + "\t");
    }
}