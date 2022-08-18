// Заполнить массив случайными числами. Найти максимальное число. 
// Посчитать среднее.

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
        System.Console.Write(array[i] + "\t");
    }
}

int max(int[] array)
{
    int maxNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxNum)
        {
            maxNum = array[i];
        }
    }
    return maxNum;
}

double findAvg(int[] array)
{
    double sum = 0;
    double avg = 0;

    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i]; // += добавить
    }
    avg = ((double)sum) / array.Length;
    return avg;
}

int[] result = fillArray(5);
printArray(result);
System.Console.WriteLine($"max = {max(result)}");
System.Console.WriteLine($"Среднее = {findAvg(result)}");