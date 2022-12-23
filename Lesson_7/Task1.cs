/*
 Задайте двумерный массив размером m×n, 
 заполненный случайными вещественными числами.
 */
bool MANUAL = false;
int horz = new Random().Next(5, 16);
int vert = new Random().Next(5, 16);
int min = new Random().Next(-20, 1);
int max = new Random().Next(10, 100);

if (MANUAL)
{
    Console.Write(" Enter a horizontal size  ");
    horz = int.Parse(Console.ReadLine()!);
    Console.Write(" Enter vertical size  ");
    vert = int.Parse(Console.ReadLine()!);
    Console.Write(" Enter minimal value  ");
    min = int.Parse(Console.ReadLine()!);
    Console.Write(" Enter maximal value  ");
    max = int.Parse(Console.ReadLine()!);
}
else
{
    Console.WriteLine($"Hello, World!\r\nSize of ({horz},{vert}) at [{min}..{max}] value is generated");
}

double[,] matrix = FillArray(vert, horz, min, max);
Console.Write(MatrixToString(matrix));




double[,] FillArray(int size1, int size2, int fmin, int fmax)
{
    double[,] field = new double[size1, size2];// int[] linear = new int[number];

    for (int i = 0; i < field.GetLength(0); i++)
    {
        for (int j = 0; j < field.GetLength(1); j++)
        {
            field[i, j] = new Random().NextDouble() * (fmax - fmin) + fmin;
        }
    }
    return field;
}

string MatrixToString(double[,] arr)
{
    string OUT = "";
    int ilen = arr.GetLength(0);
    int jlen = arr.GetUpperBound(1);
    for (int i = 0; i < ilen; i++)
    {
        OUT += "( ";
        for (int j = 0; j < jlen; j++)
        {
            OUT += String.Format("{0,6:N2} ", arr[i, j]);
        }
        OUT += String.Format("{0,6:N2} )\r\n", arr[i, jlen]);
    }
    return OUT;
}
