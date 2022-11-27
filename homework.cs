// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] Create2dArray()
{
    int[,] createdArray = new int[3, 5];
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            createdArray[i, j] = new Random().Next(1, 10);
        }
    }
    return createdArray;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] Sorter2dArrays(int[,] array)
{
    int count = 0;
    while (count < array.GetLength(0))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1)-1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j+1] = temp;
                }
            }
        }
        count++;
    }
    return array;

}

int[,] matrix = Create2dArray();
Show2dArray(matrix);
Sorter2dArrays(matrix);
System.Console.WriteLine();
Show2dArray(matrix);

//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
//строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
//наименьшей суммой элементов: 1 строка

// int[,] Create2dArray()
// {
//     int[,] createdArray = new int[4, 6];
//     for (int i = 0; i < 4; i++)
//     {
//         for (int j = 0; j < 6; j++)
//         {
//             createdArray[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return createdArray;
// }
// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[] FindRowSum(int[,] array)
// {
//     int[] sum = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum[i] += array[i, j];
//         }
//         int minSum = sum[i];
//     }
//     int minRow = 0;
//     for (int i = 0; i < sum.Length; i++)
//     {
//         if (sum[i] < sum[minRow])
//         {
//             minRow = i;
//         }
//     }
//     System.Console.Write($"The row which has the min sum of the elements is [{minRow+1}] ");;
//     return sum;
// }


// int[,] matrix = Create2dArray();
// Show2dArray(matrix);
// FindRowSum(matrix);
