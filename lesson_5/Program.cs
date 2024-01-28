// //* Задача 1: Напишите программу, которая на вход
// //* принимает позиции элемента в двумерном массиве, и
// //* возвращает значение этого элемента или же указание,
// //* что такого элемента нет
// //? 4 3 1 (1,2) => 9
// //? 2 6 9 
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Clear();
//         Console.WriteLine("Задайте размер Строки: ");
//         int Sise_y = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("задайте размер столбца: ");
//         int Sise_x = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine(" ");

//         int[,] array = CreatingArray(Sise_y, Sise_x);
//         Print(array);
//         Console.WriteLine();

//         Console.WriteLine("Задайте индекс Строки: ");
//         int Index_y = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Задайте индекс Столбца: ");
//         int Index_x = Convert.ToInt32(Console.ReadLine());
//         if (Index_y > Sise_y && Index_x > Sise_x)
//         {
//             Console.WriteLine("такого числа нет");
//         }
//         else
//         {
//             object Elements = array.GetValue(Index_y, Index_x);
//             Console.WriteLine("Элемент: " + Elements);
//         }
//     }

//     static void Print(int[,] array)
//     {
//         int Line_y = array.GetLength(0);
//         int Columns_x = array.GetLength(1);
//         for (int y = 0; y < Line_y; y++)
//         {
//             for (int x = 0; x < Columns_x; x++)
//             {
//                 Console.Write(array[y, x] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }
//     static int[,] CreatingArray(int Sise_y, int Sise_x)
//     {
//         int[,] array = new int[Sise_y, Sise_x];

//         int Line_y = array.GetLength(0);
//         int Columns_x = array.GetLength(1);

//         for (int y = 0; y < Line_y; y++)
//         {
//             for (int x = 0; x < Columns_x; x++)
//             {
//                 Console.WriteLine("Введите элемент: " + "с индексом: " + y + " с идексом: " + x);
//                 array[y, x] = int.Parse(Console.ReadLine());
//             }
//             Console.WriteLine(" ");
//         }
//         return array;
//     }
// }

//* Задача 2: Задайте двумерный массив. Напишите
//* программу, которая поменяет местами первую и
//* последнюю строку массива
//? 4 3 1     4 6 2
//? 2 6 9  => 2 6 9
//? 4 6 2     4 3 1

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Clear();
//         Console.WriteLine("Задайте размер Строки: ");
//         int Sise_y = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("задайте размер столбца: ");
//         int Sise_x = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine(" ");

//         int[,] array = CreatingArray(Sise_y, Sise_x);
//         Print(array);
//         Console.WriteLine();

//         Console.WriteLine("Введите индекс 1 строки: ");
//         int LineIndex1 = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Введите индекс 2 строки: ");
//         int LineIndex2 = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine();
//          if (LineIndex1 < 0 || LineIndex1 >= array.GetLength(0) || LineIndex2 < 0 || LineIndex2 >= array.GetLength(0) || LineIndex1 == LineIndex2)
//         {
//             Console.WriteLine("Такого индекса строки нет ");
//             return;
//         }
//         int[,] array2 = ReplacingString(array, LineIndex1, LineIndex2);

//         Print2(array2);
//     }
//     static void Print(int[,] array)
//     {
//         System.Console.WriteLine("Вывод массива: ");
//         int Line_y = array.GetLength(0);
//         int Columns_x = array.GetLength(1);
//         for (int y = 0; y < Line_y; y++)
//         {
//             for (int x = 0; x < Columns_x; x++)
//             {
//                 Console.Write(array[y, x] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }
//     static int[,] CreatingArray(int Sise_y, int Sise_x)
//     {
//         int[,] array = new int[Sise_y, Sise_x];

//         int Line_y = array.GetLength(0);
//         int Columns_x = array.GetLength(1);

//         for (int y = 0; y < Line_y; y++)
//         {
//             for (int x = 0; x < Columns_x; x++)
//             {
//                 Console.WriteLine("Введите элемент: " + "с индексом: " + y + " с идексом: " + x);
//                 array[y, x] = int.Parse(Console.ReadLine());
//             }
//             Console.WriteLine(" ");
//         }
//         return array;
//     }
//     static int[,] ReplacingString(int[,] array, int LineIndex1, int LineIndex2)
//     {

//         for (int y = 0; y < array.GetLength(0); y++)
//         {
//             for (int x = 0; x < array.GetLength(1); x++)
//             {
//                 int line = array[LineIndex1, x];
//                 array[LineIndex1, x] = array[LineIndex2, x];
//                 array[LineIndex2, x] = line;
//             }
//         }
//         return array;
//     }
//     static void Print2(int[,] array2)
//     {
//         System.Console.WriteLine("Вывод массива с заменой строк: ");
//         for (int y = 0; y < array2.GetLength(0); y++)
//         {
//             for (int x = 0; x < array2.GetLength(1); x++)
//             {
//                 Console.Write(array2[y, x] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }
// }

//* Задача 3: Задайте прямоугольный двумерный массив.
//* Напишите программу, которая будет находить строку с
//* наименьшей суммой элементов.
//? 4 3 1  
//? 2 6 9   => Строка с индексом 0
//? 4 6 2 

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Clear();
//         Console.WriteLine("Задайте размер Строки: ");
//         int Sise_y = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("задайте размер столбца: ");
//         int Sise_x = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine(" ");

//         int[,] array = CreatingArray(Sise_y, Sise_x);
//         Print(array);
//         Console.WriteLine();
//         int[,] Sum = SumArray(array);

//         int Index = MinRowIndex(array);
//     }

//     static void Print(int[,] array)
//     {
//         System.Console.WriteLine("Вывод массива: ");
//         int Line_y = array.GetLength(0);
//         int Columns_x = array.GetLength(1);
//         for (int y = 0; y < Line_y; y++)
//         {
//             for (int x = 0; x < Columns_x; x++)
//             {
//                 Console.Write(array[y, x] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }
//     static int[,] CreatingArray(int Sise_y, int Sise_x)
//     {
//         int[,] array = new int[Sise_y, Sise_x];

//         int Line_y = array.GetLength(0);
//         int Columns_x = array.GetLength(1);

//         for (int y = 0; y < Line_y; y++)
//         {
//             for (int x = 0; x < Columns_x; x++)
//             {
//                 Console.WriteLine("Введите элемент: " + "с индексом: " + y + " с идексом: " + x);
//                 array[y, x] = int.Parse(Console.ReadLine());
//             }
//             Console.WriteLine(" ");
//         }
//         return array;
//     }
//     static int[,] SumArray(int[,] array)
//     {
//         System.Console.WriteLine("Сумма всех элементов строки: ");
//         for (int y = 0; y < array.GetLength(0); y++)
//         {
//             int Sum = 0;
//             for (int x = 0; x < array.GetLength(1); x++)
//             {
//                 Sum += array[y, x];
//             }
//             Console.WriteLine($"Индекс {y} " + "=> " + Sum + " ");
//         }
//         return array;
//     }
//     static int MinRowIndex(int[,] array)
//     {
//         int index = 0, minsum = 0;
//         for (int y = 0; y < array.GetLength(0); y++)
//         {
//             int Sum = 0;
//             for (int x = 0; x < array.GetLength(1); x++)
//             {
//                 Sum += array[y, x];
//             }
//             if (y == 0)
//             {
//                 minsum = Sum;
//             }
//             else if (Sum < minsum)
//             {
//                 minsum = Sum;
//                 index = y;
//             }
//         }
//         Console.WriteLine($"Строка с индексом {index} минимальная");
//         return index;
//     }
// }