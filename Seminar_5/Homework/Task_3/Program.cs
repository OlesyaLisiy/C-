// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7.3 22.2 2 78] -> 76


double[] CreateArray(int length)
{
    double[] array = new double[length];
    int i = 0;
    while (i < length)
    {
        array[i] = Math.Round((-10 + new Random().NextDouble() * 20), 1);
        i++;
    }
    return array;
}

void printArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

void SelectionSort(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minPosition]) minPosition = j;
        }
        double temp = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temp;
    }
}

double findDiffMaxMin(double[] nums)
{
    double DiffMaxMin = (nums[nums.Length - 1]) - (nums[0]);
    return DiffMaxMin;
}

double[] array = CreateArray(10);
printArray(array);
SelectionSort(array);
printArray(array);
double DiffMaxMin = findDiffMaxMin(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {DiffMaxMin}");