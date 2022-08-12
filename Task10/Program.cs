using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите 3-хзначное число: ");
        string? Num = Console.ReadLine();
        Console.WriteLine("Вторая цифра введенного числа: " + Num![1]);
    }
}