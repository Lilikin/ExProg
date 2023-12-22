void OpenMatryoshka(int size)
{
    Console.WriteLine($"Opening matryshka of size {size}...");
    //Базовый случай: самая маленькая матрёшка
    if (size == 1)
    {
        Console.WriteLine("Reached the smallest matryshka!");
        return;
    }
    OpenMatryoshka(size - 1);
}

// //Раскручивание рекурсии
// void OpenMatryoshka(int size)
// {
//     if (size == 0)
//     {
//         Console.WriteLine("Smallest!");
//         return;
//     }
//     OpenMatryoshka(size - 1);
//     Console.WriteLine($"Opening matryshka of size {size}...");
// }

OpenMatryoshka(5);


// //эту функцию можно сделать через for (не опасно переполнением стека):
// int Fact2(int n)
// {
//     int result = 1;
//     for (int i = 2; i <= n ; i++)
//     {
//         result *= i;
//     }
//     return result;
// }

// Console.WriteLine(Fact2(0));

// int Fact(int n)
// {
//     if (n == 1 || n == 0)
//     {
//         Console.WriteLine($"Stop: {n}");
//         return 1;
//     }
//     Console.WriteLine(n);
//     return n * Fact(n - 1); //делить

// }
// Console.WriteLine(Fact(5));





// void OpenMatryoshka(int size)
// {
//     if (size == 0)
//     {
//         Console.WriteLine("Smallest!");
//         return;
//     }
//     OpenMatryoshka(size - 1);
//     Console.WriteLine($"Opening matryshka of size {size}...");
// }

