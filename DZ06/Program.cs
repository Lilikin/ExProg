// Задача 1: 
// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

// string StringFromCharArrayBivariate(char[,] array)
// {
//     string result = String.Empty;
//     foreach (var symbol in array)
//     {
//         result = result + symbol;
//     }
//     return result;
// }

// char[,] chars = {
//     { 'H', 'e', 'l', 'l', 'о', ' ' },
//     { 'W', 'o', 'r', 'l', 'd', '!'},
// };

// string result = StringFromCharArrayBivariate(chars);
// Console.WriteLine($"Result: {result}");




// Задача 2: 
// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// произвольная строчка
// Console.Write("Введите строчку: ");
// string inputString = Console.ReadLine();
// inputString = inputString.ToLower();
// Console.Write("Полученная строчка: " + inputString);



// Задача 3: 
// Задайте произвольную строку. Выясните, является ли она палиндромом.

// Console.Write("Введите строчку: ");
// string inputString = Console.ReadLine();
// inputString = inputString.ToLower();
// inputString = inputString.Replace(" ", "");
// string reternString = new string(inputString.Reverse().ToArray());
// if (inputString == reternString)
// {
//     Console.Write("Это палиндром");
// }
// else
// {
//     Console.Write("Это не палиндром");
// }


// Задача 4*(не обязательная): 
// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

// string StringFromCharArrayBivariate(char[] array)
// {
//     string result = String.Empty;
//     foreach (var symbol in array)
//     {
//         result = result + symbol;
//     }
//     return result;
// }

string GetStringFromCharArray(char[] array)
{
    string result = String.Empty; // ""
    // тип_данных имя in массив
    // var - дин. определение типа данных
    foreach (var symbol in array) // symbol = a,b,c,d
    {
        result = result + symbol;
    }
    return result;
}

// char[] chars = { 'H', 'e', 'l', 'l', 'о' };


// Console.WriteLine($"{string.Join("", chars)}");// вариант 2


char[] chars = {'Hello', 'my', 'World'};
string result = GetStringFromCharArray(chars);
Console.WriteLine($"Result: {result}"); //вариант 1
//RightToLeft