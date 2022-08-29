// Задача 2: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

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

int[] ToBinary(int num)
{
    int[] array = new int[10];
    int i = array.Length - 1;
    while (num > 0)
    {
        int bit = num % 2;
        num = num / 2;
        
        array[i] = bit;
        i--;
    }
    return array;
}

int[] array = ToBinary(Prompt("Введите число "));
PrintArray(array);