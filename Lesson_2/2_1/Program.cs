//* Напишите программу, которая принимает на вход
//* трёхзначное число и удаляет вторую цифру этого
//* Пример:
//? числа.
//? Примеры
//? a = 256 => 26
//? a = 891 => 81

// Console.WriteLine("Введите трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >= 100 && num < 1000)
// {
//     int num1 = num / 100;
//     int num2 = num % 10;
//     int result = num1 * 10 + num2;
//     Console.WriteLine(result);
// }
// else
// {
//     if (num < 100 || num > 1000)
//     {
//         Console.WriteLine("Вы ввели не трехзначное число");
//     }
// }

//! 2 Способ
// int num = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine(num / 100 * 10 + num % 10);