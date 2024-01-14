//* 3 Задача: Найдите произведения пар чисел в одномерном массиве. Парой
//* считаем первый и последний элемент, второй и предпоследний и
//* т.д. Результат запишите в новый массив.
//? Пример
//? [1 3 2 4 2 3] => [3 6 8]
//? [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)


// Console.Write("Введите количество элементов массива:\t");
// int elementsCount = int.Parse(Console.ReadLine()!);
// int[] array = new int[elementsCount];
// int[] array2 = new int[array.Length/2 + array.Length%2];

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"Введите элемент массива под индексом {i}:\t");
//     array[i] = int.Parse(Console.ReadLine()!);
// }
// Console.WriteLine($"Вывод массива:\t");
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write( array[i] + " ");
// }    
// Console.WriteLine($"\nПроизведение пар чисел: ");
// for (int i = 0; i < array.Length / 2; i++)
// {
//     array2[i] = array[i] * array[array.Length - 1 - i];
//     if (i == array .Length - 1 - i) 
//     {
//         array2[i] = array[i];
//     }
//     Console.Write(array2[i] + " ");
// }
//! 2 способ вывода
// for(int i = 0; i < array.Length / 2; i++) 
// {
//     Console.WriteLine("индекс {0} * индекс {1}, {2} * {3}  = {4}", i, array.Length - i - 1, array[i], array[array.Length - i - 1], array[i] * array[array.Length - i - 1]);
// }