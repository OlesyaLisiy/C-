// Задача 3: Напишите программу, которая задаёт массив из 
// 8 элементов, выводит их на экран. И ищет второй максимум 
// (элемент меньше максимального, но больше всех остальных)

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33], 19


int[] fillArray(int size)
{
    int[] array = new int[size];
    int i = 0;
    while (i < size)
    {
        array[i] = new Random().Next(0, 101);
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
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

int findSecondMax(int[] arr)
{
    int i = 2;
    int secondMax = arr[arr.Length - i];
    while (arr.Length - i > 1)
    {
        if (arr[arr.Length - 1] == arr[arr.Length - i])
        {
            secondMax = arr[arr.Length - i - 1];
        }
        i = i + 1;
    }
    return secondMax;
}

int[] result = fillArray(8);
printArray(result);
SelectionSort(result);
// Console.WriteLine();
// printArray(result);
int secondMax = findSecondMax(result);
Console.WriteLine();
Console.WriteLine($"Второй максимум массива равен {secondMax}");