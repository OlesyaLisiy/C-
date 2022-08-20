// Задача 3: Напишите программу, которая выводит массив 
// из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] fillArray(int size)
{
    int[] array = new int[size];
    int i = 0;
    while (i < size)
    {
        array[i] = new Random().Next(0, 2);
        i++;
    }
    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int[] result = fillArray(8);
printArray(result);
