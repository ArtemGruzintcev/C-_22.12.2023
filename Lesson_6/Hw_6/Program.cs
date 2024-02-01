//* Задача 1: Задайте двумерный массив символов (тип char
//* [,]). Создать строку из символов этого массива.
//? Пример
//? a b c => “abcdef”
//? d e f

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Clear();
//         System.Console.WriteLine("Введите количество строк: ");
//         int Sise_y = int.Parse(Console.ReadLine()!);
//         System.Console.WriteLine("Введите количество столбцов: ");
//         int Sise_x = int.Parse(Console.ReadLine()!);

//         char[,] Mass = charMass(Sise_y, Sise_x);

//         Print(Mass);

//         string Word = string.Join("", Mass);
//         Console.WriteLine(Word);
//     }
//     static char[,] charMass(int Sise_y, int Sise_x)
//     {
//         char[,] Mass = new char[Sise_y, Sise_x];
//         for (int y = 0; y < Mass.GetLength(0); y++)
//         {
//             for (int x = 0; x < Mass.GetLength(1); x++)
//             {
//                 Console.WriteLine("Введите элемент: " + "с индексом: " + y + " с идексом: " + x);
//                 Mass[y, x] = char.Parse(Console.ReadLine()!);
//             }
//             Console.WriteLine(" ");
//         }
//         return Mass;
//     }
//     static void Print(char[,] Mass)
//     {
//         System.Console.WriteLine("Вывод массива: ");
//         int Line_y = Mass.GetLength(0);
//         int Columns_x = Mass.GetLength(1);
//         for (int y = 0; y < Line_y; y++)
//         {
//             for (int x = 0; x < Columns_x; x++)
//             {
//                 Console.Write(Mass[y, x] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }
// }


//* Задача 2: Задайте строку, содержащую латинские буквы
//* в обоих регистрах. Сформируйте строку, в которой все
//* заглавные буквы заменены на строчные. 
//? Пример:
//? “aBcD1ef!-” => “abcd1ef!-”

// class Program
// {
//     static void Main(string[] args)
//     {
//         System.Console.WriteLine("Задайте произвольную строку: ");
//         string s = Console.ReadLine()!;
//         string Word = WordToLower(s);
//     }
//     static string WordToLower(string s)
//     {
//         string s2 = new string(s);
        
//         Console.WriteLine(s2.ToLower());
//         return s2;
//     }
// }


//* Задача 3: Задайте произвольную строку. Выясните,
//* является ли она палиндромом.
//? Пример:
//? “aBcD1ef!-” => Нет
//? “шалаш” => Да
//? “55655” => Да

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Clear();
//         System.Console.WriteLine("Задайте произвольную строку: ");
//         string s = Console.ReadLine()!;
//         char[] word = WordChar(s); 
//         Array.Reverse(word); // переворачиваем строку
//         string Pol = WordPal(s,word);
//     }
//     /// <summary>
//     /// Преобразовываем строку в массив
//     /// </summary>
//     /// <param name="s"></param>
//     /// <returns></returns>
//     static char[] WordChar(string s)
//     {
//        char[] text = s.ToCharArray();
//        return text;
//     }
//     /// <summary>
//     /// Проверяем являеться ли строка палиндромом
//     /// </summary>
//     /// <param name="s"></param>
//     /// <param name="word"></param>
//     /// <returns></returns>
//     static string WordPal(string s,char[] word)
//     {
//         string FinalText = new string(word); // объявим строку с инициализацией символами из массива.
//         if(s == FinalText)
//         {
//             System.Console.WriteLine("Данная запись является палиндромом");
//         }
//         if(s != FinalText) // (!=) не равняеться
//         {
//             System.Console.WriteLine("Данная запись не является палиндромом");
//         }
//         return FinalText;
//     }
// }
