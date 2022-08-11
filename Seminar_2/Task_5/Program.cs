// 2.1. Напишите программу, которая выводит случайное число 
// из отрезка [10, 9999] и показывает наибольшую цифру числа.
// 7812 -> 8 
// 1213-> 3 
// 845 -> 8


int number = new Random().Next(10, 10000);
Console.WriteLine(number);
int max = 0;

while (number > 0)
    {
    int num = number % 10;
    if (max < num)
    max = num;
    number = number / 10;
    }

Console.WriteLine(max);