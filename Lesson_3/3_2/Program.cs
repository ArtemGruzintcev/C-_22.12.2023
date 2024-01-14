//*  2 задача: Задайте массив из 10 элементов, заполненный числами из
//* промежутка [-10, 10]. Замените отрицательные элементы на
//* положительные, а положительные на отрицательные.
//? Пример:
//? [1 -5 6] => [-1 5 -6]
//! 1 вариант.

// CreateArray();

// void CreateArray()
// {
//     int[] array = new int[10]{5,-8,8,-10,7,-9,3,-4,5,-7};


//     for (int i = 0; i < array.Length; i++)
//     {
//         //* array[i] = array[i] *-1; - второй вариант
//         array[i] *= -1;  //* - первый вариант
//         Console.Write(array[i] + " ");
//     }
// }
//! 2 вариант.

// using System.Reflection.Metadata.Ecma335;

// Console.Write("Введите количество элементов массива:\t");
// int elementsCount = int.Parse(Console.ReadLine()!);
// int[] array = new int[elementsCount];

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"Введите элемент массива в деопозоне -10 до 10 под индексом {i}:\t");
//     array[i] = int.Parse(Console.ReadLine()!);
// }
// Console.Write("Вывод массива:\t");
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write( array[i] + " ");
// }
// Console.Write("Вывод массива c заменой элемента:\t");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] *= -1;
//     Console.Write( array[i] + " ");
// }
// Console.ReadLine();

//! 3 вариант.

// Console.Write("Введите количество элементов массива:\t");
// int elementsCount = int.Parse(Console.ReadLine()!);
// int[] array = new int[elementsCount];

// Console.Write("Вывод массива: ");
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-10,10);
//     Console.Write(array[i] + " ");
// }
// Console.Write("Вывод массива с заменой элемента: ");
// for(int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] = array[i] *- 1  );
// }