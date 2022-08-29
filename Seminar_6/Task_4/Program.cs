// Задача 3: Не используя рекурсию, выведите первые N 
// чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] CountFibonacci(int numberFibo)
{
    int[] array = new int[numberFibo];
    array[0] = 0;
    array[1] = 1;
    int i = 2;
    while (i < numberFibo)
    {
        array[i] = array[i - 2] + array[i - 1];
        i++;
    }
    return array;
}

void CountFibonacci1(int numberFibo)
{
    int f1 = 0;
    int f2 = 1;
    Console.Write(f1 + " ");
    Console.Write(f2 + " ");
    int f3;
    int i = 2;
    while (i < numberFibo)
    {
        int f = f1 + f2;
        f1 = f2;
        f2 = f;
        Console.Write(f + " ");
        i++;
    }
}

int[] array = CountFibonacci(Prompt("Введите число "));
PrintArray(array);
CountFibonacci1(Prompt("Введите число "));