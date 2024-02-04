//* Напишите программу, которая будет принимать на вход число и
//* возвращать сумму его цифр.
//! Указание
//! Использовать рекурсию.
//? Пример:
//? 123 => 6
//? 63 => 9

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Clear();
//         Console.WriteLine("Введите число: ");
//         int num = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Сумма цыфр цисла = " + Sum(num));
//     }
//     static int Sum(int num)
//     {
//         if (num < 10) // проверяем чтобы число было не меньше 10 
//             return num;

//         return num % 10 + Sum(num / 10);
//     }
// }


//* Задайте значение N. Напишите программу, которая выведет
//* все натуральные числа в промежутке от 1 до N.
//! Указание
//! Использовать рекурсию. Не использовать цикл.
//? Пример
//? N=5 => 1 2 3 4 5

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Clear();
//         System.Console.WriteLine("Введите число: ");
//         int N = Convert.ToInt32(Console.ReadLine());
//         Interval(N);
//     }
//     static void Interval(int N)
//     {
//        if (N == 0)
//         return;
//        Interval(N-1);
//        Console.Write(N + "\t");

//     }
// }

//* Задание 3.Считать строку с консоли, содержащую латинские буквы.
//* Вывести на экран согласные буквы этой строки.
//! Указание
//! Использовать рекурсию. Не использовать цикл.
//? Пример
//? “hello” => h l l
//? “World” => W r l d
//? “Hello world!” => H l l w r l d

// class Program
// {
//     static void Main(string[] args)
//     {
//         string wovels = ["a","e","y","u","o","i" ];
//         Console.WriteLine("Введите слово: ");
//         string text = Console.ReadLine();
//         string word = wordText(text);
//     }
//     static void wordText(string wovels, string text)
//     {
//         if (text != wovels)
//         wovels--;
//         return wordText(text);
//     }
// }