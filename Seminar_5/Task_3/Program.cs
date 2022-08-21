// Задача 2: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int[] CreateArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 100);
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

bool isPresernInArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        return true;
    }
    return false;
}

int[] nums = CreateArray(8);
printArray(nums);
int number = Prompt("Введите число для поиска ");
if (isPresernInArray(nums, number))
{
    Console.WriteLine($"Число {number} присутствует в массиве");
}
else
{
    Console.WriteLine($"Число {number} не присутствует в массиве");
}