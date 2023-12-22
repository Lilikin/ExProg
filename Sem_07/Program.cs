// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// // start = 1, end = N
// string PrintNumbers(int start, int end)
// {
//     // Базовый случай , N = 5 => "1 2 3 4 5"
//     if (start == end) return start.ToString();
//     // Рекурсивный случай
//     return start + " " + PrintNumbers(start + 1, end);
// }

// Console.WriteLine($"Печать чисел от 1 до {N} = {PrintNumbers(1, N)}");


// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

// Console.Write("Введите число N: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int SumNumbers(int num)
// {
//     // Базовый случай - случаи выхода из рекурсии 
//     if (num / 10 == 0) return num; // 45 => 5 + 4
//     // Рекурсивный случай
//     return num % 10 + SumNumbers(num / 10);
// }

// Console.WriteLine($"Сумма цифр от {number} = {SumNumbers(number)}");



using System;

class Program
{
    static void Main()
    {
        string[] strings = { "012", "defg", "hijklm", "nopqrstu" };

        string smallestString = FindSmallestString(strings);

        Console.WriteLine("Строка с наименьшей суммой: " + smallestString);
    }

    static string FindSmallestString(string[] strings)
    {
        if (strings.Length == 0)
        {
            throw new ArgumentException("Массив строк не может быть пустым.");
        }

        string smallestString = strings[0];
        int smallestSum = GetSum(smallestString);

        for (int i = 1; i < strings.Length; i++)
        {
            int currentSum = GetSum(strings[i]);

            if (currentSum < smallestSum)
            {
                smallestString = strings[i];
                smallestSum = currentSum;
            }
        }

        return smallestString;
    }

    static int GetSum(string str)
    {
        int sum = 0;
        foreach (char c in str)
        {
            sum += (int)c;
        }
        return sum;
    }
}