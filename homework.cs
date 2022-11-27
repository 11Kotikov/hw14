/* не работает что-то))
//...наверно не стоит такие комментарии оставлять в коммерческих кодах
void HelloSensei()
{
    var time = DateTime.Now;
    var dateMorning = new DateTime(2022, 11, 28, 06, 00, 00);
    var dateNoon = new DateTime(2022, 11, 28, 12, 00, 00);
    var dateEvening = new DateTime(2022, 11, 28, 18, 00, 00);
    var dateNight = new DateTime(2022, 11, 28, 00, 00, 00);

    System.Console.WriteLine(time);
    if (time > dateMorning & time < dateNoon)
    {
        System.Console.WriteLine("Доброе утро!");
    }
    if (time > dateNoon & time < dateEvening)
    {
        System.Console.WriteLine("Доброе день!");
    }
    if (time > dateEvening & time < dateNight)
    {
        System.Console.WriteLine("Добрый вечер");
    }
    if (time > dateNight & time < dateMorning)
    {
        System.Console.WriteLine("Доброй ночи.....о_о");
    }
}
HelloSensei();
*/

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

// // почему-то мне было очень сложно :) но я рад, что справился с задачей
// int[,] Create2dArray()
// {
//     int[,] createdArray = new int[3, 5];
//     for (int i = 0; i < 3; i++)
//     {
//         for (int j = 0; j < 5; j++)
//         {
//             createdArray[i, j] = new Random().Next(1, 10);
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

// int[,] Sorter2dArrays(int[,] array)
// {
//     int count = 0;
//     while (count < array.GetLength(0))
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1) - 1; j++)
//             {
//                 if (array[i, j] < array[i, j + 1])
//                 {
//                     int temp = array[i, j];
//                     array[i, j] = array[i, j + 1];
//                     array[i, j + 1] = temp;
//                 }
//             }
//         }
//         count++;
//     }
//     System.Console.WriteLine("\nugh...what a gross...give me a sec");
//     Thread.Sleep(1000);
//     System.Console.WriteLine("Ur new beautiful sorted array is:");
//     Thread.Sleep(1000);
//     return array;
// }

// int[,] matrix = Create2dArray();
// Show2dArray(matrix);
// Sorter2dArrays(matrix);
// System.Console.WriteLine();
// Show2dArray(matrix);

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
//     System.Console.Write($"And the row which has the min sum of the elements is \"{minRow+1}\" ");;
//     return sum;
// }


// int[,] matrix = Create2dArray();
// System.Console.WriteLine("Your array is:");
// Show2dArray(matrix);
// FindRowSum(matrix);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateHelix2dArray()
{
int rows = 4;
int cols = 4;
int[,] createdArray = new int[rows, cols];
// о способе заполнения периметра я догадался, а вот внутреннее наполнение пришлось погуглить, нашёл аналогичный на java:(
// код, по сути, на 70% не мой...(было сложно)
int fillNumber = 1;
for (int j = 0; j < createdArray.GetLength(1); j++)
{
    createdArray[0, j] = fillNumber;
    fillNumber++;
}
for (int i = 1; i < createdArray.GetLength(0); i++)
{
    createdArray[i, rows - 1] = fillNumber;
    fillNumber++;
}
for (int j = cols - 2; j >= 0; j--)
{
    createdArray[cols - 1, j] = fillNumber;
    fillNumber++;
}
for (int i = rows - 2; i > 0; i--)
{
    createdArray[i, 0] = fillNumber;
    fillNumber++;
}

int x = 1;
int y = 1;

while (fillNumber < rows * cols)
{
    while (createdArray[x, y + 1] == 0)
    {
        createdArray[x, y] = fillNumber;
        fillNumber++;
        y++;
    }
    while (createdArray[x + 1, y] == 0)
    {
        createdArray[x, y] = fillNumber;
        fillNumber++;
        x++;
    }
    while (createdArray[x, y - 1] == 0)
    {
        createdArray[x, y] = fillNumber;
        fillNumber++;
        y--;
    }
    while (createdArray[x - 1,y] == 0)
    {
        createdArray[x,y] = fillNumber;
        fillNumber++;
        x--;
    }
}

for (int i = 0; i < createdArray.GetLength(0); i++) {
            for (int j = 0; j < createdArray.GetLength(1); j++) {
                if (createdArray[i,j] == 0) {
                    createdArray[i,j] = fillNumber;
                }
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

int[,] matrix = CreateHelix2dArray();
Show2dArray(matrix);