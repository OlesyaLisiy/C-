// Задача 4: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного копирования.

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] CopyArray(int[] array)
{
    int[] answer = new int[array.Length];
    int i = 0;
    while (i < array.Length)
    {
        answer[i] = array[i];
        i++;
    }
    return answer;
}

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int[] array2 = array;
array[0] = 10;
PrintArray(array);
PrintArray(array2);
Console.WriteLine();
int[] array3 = CopyArray(array);
array[0] = 11;
PrintArray(array3);
PrintArray(array);
