// Задача 1: 
// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void AcceptsElement(int[,] matr)
{
    Console.WriteLine("Введите номер строки: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер стобца: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    bool flagFound = false;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == rows - 1 && j == columns - 1)
            {
                flagFound = true;
                break;
            }
        }
    }
    if (flagFound)
    {
        Console.WriteLine($"В массиве есть элемент строки - {rows}, столбца {columns} = {matr[rows - 1, columns - 1]}");
    }
    else
    {
        Console.WriteLine($"В массиве нет элемента строки - {rows}, столбца {columns}");
    }
    return;
}

// int[,] matrix = new int[4, 5];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// AcceptsElement(matrix);


// Задача 2: 
// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

void ReplacingString(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i > 0 && i < matr.GetLength(0))
            {
                int temporary = matr[i, j];
                matr[i, j] = matr[i, j];
                matr[i, j] = temporary;
            }
            else
            {
                int temporary = matr[0, j];
                matr[0, j] = matr[matr.GetLength(0) - 1, j];
                matr[matr.GetLength(0) - 1, j] = temporary;
            }
        }
    }
}


// int[,] matrix = new int[4, 5]; 
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// ReplacingString(matrix);
// PrintArray(matrix);


// Задача 3: 
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// void RowSum(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         int position = 0;
//         int sum = 0;
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             sum += matr[i, j];
//             position = i;
//         }
//         Console.WriteLine("В строке № {0} сумма элементов = {1}", position + 1, sum);
//     }
// }


void MinRowSum(int[,] matr)
{
    int[] RowSum = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int position = 0;
        //int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            RowSum[i] += matr[i, j];
            position = i;
        }
        Console.WriteLine("В строке № {0} сумма элементов = {1}", position + 1, RowSum[i]);
    }
    int MinSum = 0; // int.MaxValue;
    for (int k = 0; k < RowSum.Length; k++)
    {
        if (RowSum[MinSum] > RowSum[k]) MinSum = k;        
    }
    Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {MinSum + 1}");
}





int[,] matrix = new int[4, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
MinRowSum(matrix);






// void MinRowSum(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         int position = 0;
//         int sum = 0;
//         int MinSum = int.MaxValue;
//         int indexMinSum = 0;
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             sum += matr[i, j];
//             position = i;

//         //    if (sum < MinSum && sum == MinSum)
//         //     {
//         //         MinSum = sum;
//         //         indexMinSum = i;
//         //     // Console.WriteLine("В строке № {0} наименьшая сумма элементов = {1}", indexMinSum + 1, MinSum);   
//         //     }
//         //    Console.WriteLine("В строке № {0} наименьшая сумма элементов = {1}", indexMinSum + 1, MinSum);
//             //break;
//         }
//         Console.WriteLine("В строке № {0} сумма элементов = {1}", position + 1, sum);

//        //continue;
//     //    break;

//     }
//    // Console.WriteLine("В строке № {0} наименьшая сумма элементов = {1}", indexMinSum + 1, MinSum);

// }





// void MinString(int[,] matr, int[] sum)
// {
//     static void RowSum(int[,] matr)
//     {
//     Array.Sort(sum);
//     if (sum.Length>0)
//     {
//         Console.WriteLine($"Наименьшая сумма элементов равна " + sum[0]);
//     }
//     }
//     // var min = sum.Min();
//     // // int MinSum = int.MaxValue;
//     // // if (sum < MinSum)
//     // // {
//     // //     sum = MinSum;

//     // // }

// }
// MinString(matrix);










