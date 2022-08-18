// Задача 2 Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int aX = Prompt("Введите координату по оси x первой точки ");
int aY = Prompt("Введите координату по оси y первой точки ");
int aZ = Prompt("Введите координату по оси z первой точки ");
int bX = Prompt("Введите координату по оси x второй точки ");
int bY = Prompt("Введите координату по оси y второй точки ");
int bZ = Prompt("Введите координату по оси z второй точки ");

double result = Math.Sqrt((aX - bX) * (aX - bX) + (aY - bY) * (aY - bY) + (aZ - bZ) * (aZ - bZ));
System.Console.WriteLine($"Расстояние между точками равно {result}");