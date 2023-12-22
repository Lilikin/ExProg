// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// // start = M, end = N
// string PrintNumbers(int start, int end)
// {
//     if (N < M) throw new ArgumentException("N - должна быть больше M");
//     if (start == end) return start.ToString();
//     return start + " " + PrintNumbers(start + 1, end);
// }
// Console.WriteLine($"Печать чисел от {M} до {N} = {PrintNumbers(M, N)}");


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());

// int Ackermann(int N, int M)
// {
//     if (N < 0 || M < 0) throw new ArgumentException("Функция только для положительных чисел!");
//     if (N == 0) return M + 1;
//     if (M == 0) return Ackermann(N - 1, 1);
//     return Ackermann(N - 1, Ackermann(N, M - 1));
// }
// Console.WriteLine($"Функция Аккермана для чисел: {N} и {M} = {Ackermann(N, M)}");


// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(11);
}
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");


void ReversedRecursion(int[] arr, int start = 0)
{
    if (start != arr.Length)
    {
        ReversedRecursion(arr, start + 1);
        Console.Write($"{array[start]}  ");
    }
}
Console.Write("Рекурсия массива:  ");
ReversedRecursion(array);


// int[] array = { 1, 2, 3, 4, 5 };
// void ReversedRecursion(int[] arr, int start = 0)
// {
//     if (start != arr.Length)
//     {      
//         ReversedRecursion(arr, start + 1);
//         Console.Write($"{arr[start]} ");
//     }
//     }
// ReversedRecursion(array);











