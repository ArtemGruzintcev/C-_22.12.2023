//* Напишите программу, которая будет принимать на вход число и
//* возвращать сумму его цифр.
//! Указание
//! Использовать рекурсию.
//? Пример:
//? 123 => 6
//? 63 => 9

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine()!);
        System.Console.WriteLine(Sum(num));
    }
    static int Sum(int num)
    {
        if (num > 10) // проверяем чтобы число было не меньше 10 
            return num;

        return num % 10 + Sum(num / 10);
    }
}