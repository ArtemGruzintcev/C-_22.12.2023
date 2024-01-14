// * 1 задача: Задайте массив. Напишите программу,
//* которая определяет, присутствует ли заданное число в массиве.
//* [1 3 4 19 3], 8 => Нет
//* [-4 3 4 1], 3 => Да 

//! 1 вариант.
// CreateArray(); //* вызов функции

// void CreateArray() //* Функция
// {
//     System.Console.WriteLine("Введите число");
//     int num = Convert.ToInt32(Console.ReadLine());
//     bool isFind = false; //* есть ли такое число которое ввел пользователь
//     int[] array = new int[10];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,10);
//         Console.Write(array[i]+ " ");
//         if(array[i] == num)
//         {
//             isFind = true; //* если число совпадает выводи "true"
//         }
//     }

//       if (isFind == true)  //* если поменялось
//         {
//             Console.Write("Да");
//         }
//         else
//         {
//             Console.Write("Нет");
//         }
// }

//! 2 вариант.
// Console.Write("Введите количество элементов массива:\t");
// int elementsCount = int.Parse(Console.ReadLine()!);
// int[] array = new int[elementsCount];

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"Введите элемент массива под индексом {i}:\t");
//     array[i] = int.Parse(Console.ReadLine()!);
// }
// Console.Write("Вывод массива:\t");
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write( array[i] + " ");
// }
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// bool isFind = false;
// for(int i = 0; i < array.Length; i++)
// {
//     if (array[i] == num)
//     {
//         isFind = true;
//     }
// }
// if (isFind == true)
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine("Нет");
// }