// Задача 1: 
// Напишите программу, которая бесконечно запрашивает целые 
// числа с консоли. Программа завершается при вводе 
// символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// while (true)
// {
//     Console.WriteLine("Введите число (для выхода сумма чисел должан быть чётная, либо наберите 'q'): ");
//     string str = Console.ReadLine();
//     if (str == "q")
//     {
//         break;
//     }
//     if (int.TryParse(str, out int number))
//     {
//         int sum = 0;
//         while (number > 0)
//         {
//             sum = sum + number % 10;
//             number /= 10;
//         }
//         if (sum % 2 == 0)
//         {
//             Console.WriteLine($"Вы ввели число {str}, у которого сумма чисел {sum} - чётная");
//             break;
//         }
//     }
//     else
//     {
//         Console.WriteLine("Не удалось распознать число.");
//     }
// }






// // Задача 2: 
// // Задайте массив заполненный случайными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.

// int size = 10;
// int[] array = new int[size];
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 1000);
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




// Задача 3: 
// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

int size = 10;
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}
Console.WriteLine($"Массив до изменения: [{string.Join("; ", array)}]");
Array.Reverse(array);
Console.WriteLine($"Массив после изменения: [{string.Join("; ", array)}]");