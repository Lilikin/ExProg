//Задача 2
// using System;

// public class Answer {
    
//   static int FindMax(int a, int b, int c)
//     {
//       // Введите свое решение ниже
//       int max = a;
//     if (b > max) max = b;
//     if (c > max) max = c;
//     return max;
      



//     }

//   // Не удаляйте и не меняйте метод Main! 
//   static public void Main(string[] args) {
//         int a, b, c;

//         if (args.Length >= 3) {
//            a = int.Parse(args[0]);
//            b = int.Parse(args[1]);
//            c = int.Parse(args[2]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            a = 9;
//            b = 13;
//            c = 7;
//         }

//         // Не удаляйте строки ниже
//         int result = FindMax(a, b, c);
//         System.Console.WriteLine($"{result}");
//     }
// }



//Задача 3
// using System;

// class Answer {
//     static void CheckIfEven(int number)
//     {
//       // Введите свое решение ниже
//       if (number % 2 == 0) {
        
//     Console.WriteLine($"Число `{number}` чётное");
//        }
//         else {
        
//     Console.WriteLine($"Число `{number}` не чётное");
//        }


//     }
  

//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 7;
//         }

//         // Не удаляйте строки ниже
//         CheckIfEven(number);
//     }
// }




//Задача 4

public class Answer {
    static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже
      
      int index = 2;

            while (index <= number) {
                Console.Write(index + "\t");
                index += 2;
                }
                   
             
   // Console.Write($"number = {number} -> ");
    //Console.Write(index + "\t");
    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 6;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}