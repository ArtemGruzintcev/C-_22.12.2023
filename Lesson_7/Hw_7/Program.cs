//* Задача 1: Задайте значения M и N. 
//* Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//! Использовать рекурсию, не использовать циклы.
// class Program
// {
//     static void Main(string[] args)
//     {
//         System.Console.WriteLine("M =  ");
//         int M = Convert.ToInt32(Console.ReadLine()!);
//         System.Console.WriteLine("N = ");
//         int N = Convert.ToInt32(Console.ReadLine()!);
//         Interval(M, N);

//     }
//     static int Interval(int M, int N)
//     {
//         if (M <= N)
//         {
//             Console.Write(M + " ");
//             M++;
//             Interval(M, N);
//         }
//         return M;
//     }
// }

//* Задача 2: Даны два неотрицательных числа m и n. 
//! Напишите программу вычисления функции Аккермана с помощью рекурсии.
//? M = 3, N = 2 -> A(M,N) = 29
// class Program
// {
//     static void Main(string[] args)
//     {
//         System.Console.WriteLine("M = ");
//         int M = Convert.ToInt32(Console.ReadLine()!);
//         System.Console.WriteLine("N = ");
//         int N = Convert.ToInt32(Console.ReadLine()!);
//         Console.WriteLine(Ackerman(M,N));
//     }
//     static int Ackerman(int M, int N)
//     {
//         if (M < 0 || N < 0) throw new ArgumentOutOfRangeException();
//         if (M == 0) return N + 1;
//         if (N == 0) return Ackerman(M - 1, 1);
//         return Ackerman(M - 1, Ackerman(M, N - 1));
//     }
// }


//* Задача 3: Задайте произвольный массив.
//* Выведете его элементы, начиная с конца.
//! Использовать рекурсию, не использовать циклы.
//? Пример:
//? [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Clear();
//         int[] array = {1, 2, 5, 0, 10, 34};
//         Array.Reverse(array);
//         PrintArray(array);
//     }
//     static void PrintArray(int[] array, int i = 0)
//     {
//         if (i < array.Length )
//         {
//             Console.Write(array[i] + "\t");
//             PrintArray(array, i + 1);
//         }
//     }
// }