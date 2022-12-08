// принимает на вход координаты двух точек и находит расстояние между ними в 3D
Console.WriteLine("Введите координаты двух точек");

//проверки диапазонов и корректности не ставил.
Console.WriteLine(" Первая по X :");
double x1 = double.Parse(Console.ReadLine()!);
Console.WriteLine(" Первая по Y :");
double y1 = double.Parse(Console.ReadLine()!);
Console.WriteLine(" Первая по Z :");
double z1 = double.Parse(Console.ReadLine()!);

Console.WriteLine(" Вторая по X :");
double x2 = double.Parse(Console.ReadLine()!);
Console.WriteLine(" Вторая по Y :");
double y2 = double.Parse(Console.ReadLine()!);
Console.WriteLine(" Вторая по Z :");
double z2 = double.Parse(Console.ReadLine()!);

double result = Math.Round( Math.Sqrt( Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2)),3);
Console.WriteLine("Расстояние между точками  :" + result);
