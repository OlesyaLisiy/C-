// Задача 1: Напишите программу, которая перевернёт 
// одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


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

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double[] ReverseArray(double[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        double tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
    return array;
}

double[] array = CreateArray(6);
PrintArray(array);
ReverseArray(array);
PrintArray(array);