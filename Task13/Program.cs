using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число");
        string? Num = Console.ReadLine();
        int NumLenght = Num!.Length;

        if (NumLenght < 3)
        {
            Console.WriteLine ("3-й цифры нет");
        }
        else
        {
          Console.WriteLine ("3-я цифра введенного числа: " + Num![2]);
        }

    }
}