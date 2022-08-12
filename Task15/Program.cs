using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите день недели: ");
        int Day = Convert.ToInt32(Console.ReadLine());

        if ((Day == 6)^(Day == 7))
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }
}