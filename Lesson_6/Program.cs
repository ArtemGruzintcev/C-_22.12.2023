//* Задайте массив символов (тип char []). Создайте строку из
//* символов этого массива.
//! Указание
//! Конструктор строки вида string(char []) не использовать.
//? Пример
//? [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

// class Program
// {
//     static void Main(string [] args)
//     {
//         Console.Clear();
//         char[] chars = new char[] {'a','b','c','d'};
//         for (int y = 0; y < chars.Length; y++)
//         {
//             Console.Write(chars[y]);
//         }
//         Console.ReadLine();
//     }
// }

//* На основе символов строки (тип string) сформировать массив
//* символов (тип char[]). Вывести массив на экран.
//? Пример
//? “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’] 

// class Program
// {
//     static void Main(string [] args)
//     {
//         Console.Clear();
//         string Hello = "Hello!";
//         char [] chars = new char[Hello.Length];
//         for (int y = 0; y < Hello.Length; y++)
//         {
//             chars[y] = Hello[y];
//             Console.Write(chars[y] + "\t");
//         }
//         Console.ReadLine();
//     }
// }

//* Считать строку с консоли, состоящую из латинских
//* букв в нижнем регистре. Выяснить, сколько среди
//* введённых букв гласных.
//? Пример
//? “hello” => 2
//? “world” => 1

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Clear();
//         Console.WriteLine("Введите слово: ");
//         string word = Console.ReadLine();
//         char[] charWord = new char[word.Length];
//         for (int y = 0; y < word.Length; y++)
//         {
//             charWord[y] = word[y];
//         }
//         int vowelsCount = GetVowelsCount(charWord);
//         Console.WriteLine($"Гласных в слове {word} = " + vowelsCount);
       
//     }
//     static int GetVowelsCount(char[] charWord)
//     {
//         char[] vowels = new char[] { 'a', 'e', 'y', 'i', 'o', 'u' }; //Гласные

//         int vowelsCount = 0;

//         foreach (char word in charWord)
//         {
//             foreach (char litter in vowels)
//             {
//                 if (word == litter)
//                 vowelsCount++;
//             }
//         }
//         return vowelsCount;
//     }
// }



