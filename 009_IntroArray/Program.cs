//Вариант 1
// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// // в массиве индекс массива
// //             0   1   2   3   4   5   6   7   8
// int[] array = {11, 21, 31, 41, 15, 61, 17, 18, 19};

// int result = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
// );


// Console.WriteLine(result);

//Вариант 2

int[] array = {19, 21, 31, 41, 4, 61, 17, 18, 19};

int n = array.Length;
int find = 21;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1;
    index++;    
}

