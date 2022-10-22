// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.


int FillArray(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double b1 = FillArray("Введите значение b1: ");
double k1 = FillArray("Введите значение k1: ");
double b2 = FillArray("Введите значение b2: ");
double k2 = FillArray("Введите значение k2: ");


double x = (b2 - b1)/(k1 - k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");