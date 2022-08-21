// Задача 2: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] CreateArray(int length)
{
    int[] array = new int[length];
    int i = 0;
    while (i < length)
    {
        array[i] = new Random().Next(-99, 100);
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

int SumOddNumbers(int[] nums)
{
    int sum = 0;
    for (int i = 0; i < nums.Length; i+=2)
    {
        sum = sum + nums[i];
    }
    return sum;
}

int[] array = CreateArray(10);
printArray(array);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях в массиве равна {SumOddNumbers(array)}");