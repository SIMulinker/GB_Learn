/* Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/


bool MANUAL = false;
Random rnd = new Random();

int size1 = rnd.Next(5, 16);
int size2 = rnd.Next(5, 16);
int min = rnd.Next(1, 10);
int max = rnd.Next(10, 100);

if (MANUAL)
{
    bool succes = false;
    while (!succes)
    {
        Console.Write("Enter horizontal size ");
        succes = int.TryParse(Console.ReadLine()!, out size2);
    }
    succes = false;
    while (!succes)
    {
        Console.Write("Enter vertical size ");
        succes = int.TryParse(Console.ReadLine()!, out size1);
    }
    succes = false;
    while (!succes)
    {
        Console.Write("Enter minimal value ");
        succes = int.TryParse(Console.ReadLine()!, out min);
    }
    succes = false;
    while (!succes)
    {
        Console.Write("Enter maximal value ");
        succes = int.TryParse(Console.ReadLine()!, out max);
    }
}
Console.WriteLine($"Field size({size1},{size2}) at min:{min} to max:{max}");
int[,] matrix = CreateMatrix(size1, size2, min, max);// from acually contains zero
PrintMatrix(matrix);
Console.WriteLine();
int line = FindMinimalLine(matrix);
if (line >= 0)
{
    Console.WriteLine(" line of minimal summ :" + line);
}
else
{
    Console.WriteLine("Sorry, this a line is duplicate, or another error");
}

int FindMinimalLine(int[,] inner)
{
    int findIt = -1;
    int minvalue = int.MaxValue;
    for (int i = 0; i < inner.GetLength(0); i++)
    {
        int rowsum = 0;
        for (int j = 0; j < inner.GetLength(1); j++)
        {
            rowsum += inner[i, j];
        }
        if (minvalue > rowsum)
        {
            findIt = i;
            minvalue = rowsum;
        }
        else if (minvalue == rowsum)
        {
            // return findIt;
            return -1;// two or more lines are equals
        }
    }
    return findIt;
}


int[,] CreateMatrix(int row, int col, int fmin, int fmax)
{
    int[,] matrix = new int[row, col];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(fmin, fmax + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int checksum =0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}");
            checksum += matrix[i,j];
        }
        Console.WriteLine("   ->  "+checksum);
    }
}
