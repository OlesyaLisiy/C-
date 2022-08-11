// 2. Напишите программу, которая выводит случайное
// число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8


int number = new Random().Next(10, 100);
Console.WriteLine(number);

int num1 = number / 10;
int num2 = number % 10;
int result;

if (num1 > num2) {
    result = num1;
} else
{
    result = num2;
}

Console.WriteLine($"Наибольшая цифра {result}");