// Задача 3: Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int aX = Prompt("Введите координату по оси x первой точки ");
int aY = Prompt("Введите координату по оси y первой точки ");
int bX = Prompt("Введите координату по оси x второй точки ");
int bY = Prompt("Введите координату по оси y второй точки ");

double result = Math.Sqrt((aX - bX) * (aX - bX) + (aY - bY) * (aY - bY));
System.Console.WriteLine(result);