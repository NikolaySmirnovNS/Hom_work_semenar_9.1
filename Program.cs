// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа
//  в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

class Program
{
    static void Main()
    {
        Console.WriteLine("Задайте значение N:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Результат:");
        PrintNumbers(n);
    }

    static void PrintNumbers(int n)
    {
        if (n <= 1)
        {
            Console.WriteLine(n);
            return;
        }

        Console.WriteLine(n);
        PrintNumbers(n - 1);
    }
}
