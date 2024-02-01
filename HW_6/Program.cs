class Program
{
    static char MassChars(char Sise_y, char Sise_x)
    {
        char[,] mass = new char[Sise_y,Sise_x];
        for (char i = 0; i < char.GetLenght(0) ; i++)
        {
            for (char j = 0; j < char.GetLength(1); j++)
            {
                Console.WriteLine("Введите элемент: " + "с индексом: " + i + " с идексом: " + j);
                Console.ReadLine();
            }
        }
        return mass;
    }
    static void main (string[] arr)
    {
        
        System.Console.WriteLine("Задайте размер строки");
        char Sise_y = char.Parse(Console.ReadLine());
        System.Console.WriteLine("Задайте размер столбца");
        char Sise_x = char.Parse(Console.ReadLine());

        char[,] mass = MassChars(Sise_y,Sise_x);
    }
}