// Задача 4: Найдите произведение пар чисел 
// в одномерном массиве. Парой считаем первый 
// и последний элемент, второй и предпоследний 
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] CreateArray(int length)
{
    int[] array = new int[length];
    int i = 0;
    while (i < length)
    {
        array[i] = new Random().Next(0, 10);
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

int[] MultPairs(int[] nums)
{
    int count = nums.Length;
    int[] result = new int[(count / 2) + (count % 2)];
    result[result.Length - 1] = nums[result.Length - 1];
    for (int i = 0; i < (count / 2); i++)
    {
        result[i] = nums[i] * nums[nums.Length - i - 1];
    }
    return result;
}

int[] array = CreateArray(9);
printArray(array);
printArray(MultPairs(array));