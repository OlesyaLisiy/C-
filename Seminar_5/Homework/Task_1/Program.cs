// Задача 1: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] CreateArray(int length)
{
    int[] array = new int[length];
    int i = 0;
    while (i < length)
    {
        array[i] = new Random().Next(100, 1000);
        i++;
    }
    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int SumEvenNumbers(int[] nums)
{
    int sum = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] % 2 == 0)
        {
            sum++;
        }
    }
    return sum;
}

int[] array = CreateArray(10);
printArray(array);
Console.WriteLine($"Количество чётных чисел в массиве равно {SumEvenNumbers(array)}");