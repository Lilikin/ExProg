// Задача 1 

// // Напишите программу, которая принимает на вход два числа и проверяет, 
// // является ли одно число квадратом другого.
// // Квадрат в ОБЕ стороны.
// // 5, 25 -> да
// // -4, 16 -> да
// // 25, 5 -> да
// // 8,9 -> нет

// int a = 25;
// int b = 55;

// if (a == b*b || b == a*a)
// {
//     Console.WriteLine("Да");
// }
// else Console.WriteLine("Нет");


// //Задача 2
// // Напишите программу, которая принимает на вход координаты точки (X и Y), 
// // причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// // в которой находится эта точка.


// Console.WriteLine("Введите координаты точки Х: ");
// int X = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты точки Y: ");
// int Y = Convert.ToInt32(Console.ReadLine());
// if (X > 0 && Y > 0)
// {
//     Console.WriteLine("Координаты находятся в I координатной четверти плоскости.");

// }
// else if (X > 0 && Y < 0)
// {
//     Console.WriteLine("Координаты находятся в IV координатной четверти плоскости.");
// }

// else if (X < 0 && Y < 0)
// {
//     Console.WriteLine("Координаты находятся в III координатной четверти плоскости.");
// }

// else if (X < 0 && Y > 0)
// {
//     Console.WriteLine("Координаты находятся в II координатной четверти плоскости.");
// }
// else
// {
//     Console.WriteLine("Введите координаты не равные 0.");    
// }







// // Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
// // а на выходе показывает его цифры через запятую.

// Console.WriteLine("Введите четырехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int firstDigit = number / 1000; 
// int secondDigit = (number % 1000) / 100;
// int fourthDigit = (number % 100) / 10;
// int thirdDigit = number % 10; 


// Console.WriteLine($"{firstDigit}, {secondDigit}, {fourthDigit}, {thirdDigit}");


// Задача 3: Напишите программу, которая выводит третью с начала
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 6
// 91 => Третьей цифры нет
//str.Length >= 2 // длина 

// Вариант 1 без проверки
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int fnumber(int num)
// {
// while (num > 999)
// {
//     num /=10;
// }
// return num % 10;
// }
// bool check(int num)
// {
//     if(num < 100)
//     return false;
//     else return true;
// }
// if (check(num) != true)
// Console.WriteLine($"Вы ввели число {num}. Третьей цифры нет");
// else
// Console.WriteLine($"Вы ввели число {num}. Третья цифра: {fnumber(num)}");


// Вариант 2 без проверки
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string str = num.ToString();
// if (str.Length >= 3)
// {
//     Console.WriteLine($"Вы ввели число {num}. Третья цифра: {str[2]}");
// }
// else
// Console.WriteLine($"Вы ввели число {num}. Третьей цифры нет");


///!!!!
///// if (!Regex.IsMatch(num, @"^[()+\-*\\\d\s.]*$"))
// {
//     Console.WriteLine("error");
// }



// Вариант 2
// while (true)
// {
// Console.WriteLine("Введите число: ");
// //int num = Convert.ToInt32(Console.ReadLine());
// string str = Console.ReadLine();

// //string str = num.ToString();




// if (int.TryParse(str, out int number))
//     {
//         Console.WriteLine("Вы ввели число {0}", number);
//        // break;
//     }
//     else
//     Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");

// if (str.Length >= 3)
// {
//     Console.WriteLine($"Третья цифра: {str[2]}");
// break;
// }
// else
// Console.WriteLine("Третьей цифры нет");

// }

// }
// else   


// while (a >= 100) a /= 10 
// int d = a % 10;
// return d

// if (a < 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else   
// Console.WriteLine($"Третья цифра: {d}");

while(true)
{
Console.WriteLine("Введите число: ");
string str = Console.ReadLine();

if (int.TryParse(str, out int number))

    if (str.Length >= 3)
    {
       Console.WriteLine($"Вы ввели число {number}. Третья цифра: {str[2]}");
       break; 
    }
    else
    {
    Console.WriteLine("Не удалось распознать число, либо число не имеет третьей цифры. Попробуйте еще раз.");
    }
 }
   





// Console.WriteLine("Введите число: ");
// string str = Console.ReadLine();

// if (int.TryParse(str, out int number))
//     {
//        Console.WriteLine("Вы ввели число {0}", number);
       
//         if (str.Length >= 3)
//         {
//             Console.WriteLine($"Третья цифра: {str[2]}");
//         }
//         else
//          Console.WriteLine("Третьей цифры нет");
   
//    }
//     else
//     Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");