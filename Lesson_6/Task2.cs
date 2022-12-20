/*
Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
*/

Console.Write("Enter b1 :");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Enter k1 :");
double k1 = double.Parse(Console.ReadLine()!);

Console.Write("Enter b2 :");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write("Enter k2 :");
double k2 = double.Parse(Console.ReadLine()!);

if (k1 != k2)
{
    double isX = Math.Round(findX(b1, k1, b2, k2), 2);
    double isY = Math.Round(findY(isX, b1, k1), 2);
    Console.WriteLine($"\r\n ({isX};{isY})");
}
else Console.WriteLine("\r\nLines is not crossed");

double findX(double fb1, double fk1, double fb2, double fk2)
{
    if (fk1 > fk2) return((fb2 - fb1) / (fk1 - fk2));// Great thanks for Maria Hlyustova
    else return((fb1 - fb2) / (fk2 - fk1)); // from this lowhack
}

double findY(double fx, double fby, double fky)
{
    return (fx * fky + fby);
}
