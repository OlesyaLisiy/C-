// Задача 1: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

// int SumNegativeElements(int[] nums)
// {
//     int sum = 0;
//     for (int i = 0; i < nums.Length; i++)
//     {
//         if (nums[i] < 0)
//         {
//             sum += nums[i];
//         }
//     }
//     return sum;
// }
// int SumPositiveElements(int[] nums)
// {
//     int sum = 0;
//     for (int i = 0; i < nums.Length; i++)
//     {
//         if (nums[i] > 0)
//         {
//             sum += nums[i];
//         }
//     }
//     return sum;
// }

const int minus = -1;
const int plus = 1;

int SumSignedElements(int[] array, int sign = plus)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] * sign) > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int[] array = CreateArray(12, -9, 9);
printArray(array);
// int sumPositive = SumPositiveElements(array);
// int sumNegative = SumNegativeElements(array);
int sumPositive = SumSignedElements(array, plus);
int sumNegative = SumSignedElements(array, minus);
Console.WriteLine($"Сумма отрицательных равна {sumNegative}, а положительных равна {sumPositive}");
