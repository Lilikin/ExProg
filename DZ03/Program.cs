﻿// // Задача 1: 
// // Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// // Найдите количество элементов массива, значения 
// // которых лежат в отрезке [20,90].

// int size = 10;
// int[] array = new int[size];
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(101);
// }

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 19 && array[i] < 91)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"В массиве: [{string.Join("; ", array)}]");
// Console.WriteLine($"Элементов лежащих в отрезке [20,90]: {count}");


// // Задача 2: 
// // Задайте массив на 10 целых чисел. Напишите программу, 
// // которая определяет количество чётных чисел в массиве.

// int size = 10;
// int[] array = new int[size];
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next();
// }

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Массив: [{string.Join("; ", array)}]");
// Console.WriteLine($"Чётных чисел в массиве: {count}");



// // Задача 3: 
// // Задайте массив из вещественных чисел с ненулевой дробной частью. 
// // Найдите разницу между максимальным и минимальным элементов массива.

// //Вечсчественные числа со знаками за запятой
// double[] res = new double[10];

// for (int i = 0; i < res.Length; i++)
// {
//     // Math.Round(число, кол-во знаков)
//     res[i] = Math.Round(new Random().NextDouble() * new Random().Next(1001), 2);
// }
// Console.WriteLine($"Результат: [ {string.Join("; ",res)} ]");
// Console.WriteLine("Минимальный элемент: " + res.Min());
// Console.WriteLine("Максимальный элемент: " + res.Max());
// Console.WriteLine($"Разница между максимальным и минимальным элементов массива составляет: {res.Max() - res.Min()}");


// Задача 4**(не обязательно): 
// Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, 
// младший – на последнем. Размер массива должен быть равен количеству цифр.

// Решали на семинаре