// Задача 3: Задайте одномерный массив из 123 
// случайных чисел. Найдите . 
// Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int[] CreateArray(int length)
{
    int[] array = new int[length];
    int i = 0;
    while (i < length)
    {
        array[i] = new Random().Next(0, 1000);
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

int CountNumbers(int[] nums)
{
    int count = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] >= 10 && nums[i] <= 99)
        {
            count++;
        }
    }
    return count;
}

int[] array = CreateArray(123);
printArray(array);
System.Console.WriteLine();
Console.WriteLine($"Kоличество элементов массива, значения которых лежат в отрезке [10,99] равно {CountNumbers(array)}");
