// Задача 1: Напишите программу замены 
// элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] CreateArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-1000, 1000);
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

int[] Changedigits(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = -nums[i];
    }
    return nums;
}

int[] array = CreateArray(8);
printArray(array);
printArray(Changedigits(array));
