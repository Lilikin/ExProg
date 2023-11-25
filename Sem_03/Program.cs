// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

// // Массив на 8 РАНДОМНЫХ элементов
// int size = 8;
// int[] array = new int[size]; // Массив на 8 элементов
// // В массиве 8 нулей: [0,0,0,0,0,0,0,0]
// int numberForSearch = new Random().Next(11); // [0, 10]
// // (начало, условие, увл. счетчика), i++ (i = i + 1)
// for (int i = 0; i < array.Length; i++) // array.Length = size
// {
//     array[i] = new Random().Next(101); // 0-100
//     if (array[i] == numberForSearch)
//     {
//         Console.WriteLine("+");
//         break; // Если элемент нашли, вывели "+" и цикл окончили
//     }
//     else
//     {
//         Console.WriteLine("-");
//     }
// }
// Console.WriteLine(numberForSearch);
// Console.WriteLine($"Массив: [{string.Join("; ",array)}]");


// // Массив на 8 РАНДОМНЫХ элементов
// int size = 8;
// int[] array = new int[size]; // Массив на 8 элементов
// // В массиве 8 нулей: [0,0,0,0,0,0,0,0]
// int numberForSearch = new Random().Next(11); // [0, 10]
// bool flagFound = false; // false - элемент НЕ найден
// // (начало, условие, увл. счетчика), i++ (i = i + 1)
// for (int i = 0; i < array.Length; i++) // array.Length = size
// {
//     array[i] = new Random().Next(21); // 0-100
//     if (array[i] == numberForSearch)
//     {
//         flagFound = true; // Элемент нашли
//         break; // Если элемент нашли, вывели "+" и цикл окончили
//     }
// }
// Console.WriteLine($"[ {string.Join("; ",array)} ]");
// if (flagFound) // == true
// {
//    Console.WriteLine($"Число {numberForSearch} НАЙДЕНО");
// }
// else
// {
//     Console.WriteLine($"Число {numberForSearch} НЕ НАЙДЕНО");
// }

// // Массив на 8 РАНДОМНЫХ элементов
// int size = 8;
// int[] array = new int[size]; // Массив на 8 элементов
// // В массиве 8 нулей: [0,0,0,0,0,0,0,0]
// int numberForSearch = new Random().Next(11); // [0, 10]
// string flagFound = "не найден"; // false - элемент НЕ найден
// // (начало, условие, увл. счетчика), i++ (i = i + 1)
// for (int i = 0; i < array.Length; i++) // array.Length = size
// {
//     array[i] = new Random().Next(21); // 0-100
//     if (array[i] == numberForSearch)
//     {
//         flagFound = "найден"; // Элемент нашли
//         break; // Если элемент нашли, вывели "+" и цикл окончили
//     }
// }
// Console.WriteLine($"[ {string.Join("; ",array)} ]");
// Console.WriteLine($"Элемент {numberForSearch}:{flagFound}");


// // Задайте массив из 10 элементов, заполненный числами из
// // промежутка [-10, 10]. Замените отрицательные элементы на
// // положительные, а положительные на отрицательные.
// // Пример
// // [1 -5 6]
// // => [-1 5 -6]

// int size = 10;
// int[] array = new int[size];
// for (int i = 0; i < array.Length; i++) // array.Length = size
// {
//     array[i] = new Random().Next(-10, 11);  
// }
// Console.WriteLine($"Массив ДО: [ {string.Join("; ",array)} ]");

// // 10 *(-1) = -10
// // -5 *(-1) = 5
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] *= -1;
// }
// Console.WriteLine($"Массив ПОСЛЕ: [ {string.Join("; ",array)} ]");

// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)


// int newSize = size/2 + sizeof%2 - подходит и для чётных и нечётных форм
// newSize (size - 6) = 6/2 + 6%2 = 3 + 0
// newSize (size - 3) = 3/2 + 3%2 = 1 + 1

// j = size - 1 (индекс самого последнего элемента); j-- (найти предпоследний элемент)
// i = 0, i++ (индекс с левой части от нуля)

// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5 7] 
// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// for (int i = 0; i < array.Length; i++) // array.Length = size
// {
//     array[i] = new Random().Next(-10, 11);  
// }
// Console.WriteLine($"Массив: [ {string.Join("; ",array)} ]");
// // [10, 20, 30] => [300, 20]
// int newSize = size / 2 + size % 2;
// int[] result = new int[newSize];
// for (int i = 0, j = size - 1; i < size / 2; i++, j--)
// {
//     result[i] = array[i] * array[j];
// }
// if (array.Length % 2 == 1) // Размер массива - нечетный
// {
//     result[newSize - 1] = array[size / 2]; // array[1]
//     // В посл. элемент массива кладем число БЕЗ пары
// }
// Console.WriteLine($"Результат: [ {string.Join("; ",result)} ]");

// //Вечсчественные числа со знаками за запятой
// double[] res = new double[10];

// for (int i = 0; i < res.Length; i++)
// {
//     // Math.Round(число, кол-во знаков)
//     res[i] = Math.Round(new Random().NextDouble() * new Random().Next(1001), 2);
// }
// Console.WriteLine($"Результат: [ {string.Join("; ",res)} ]");