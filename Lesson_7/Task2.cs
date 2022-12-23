/*
 Напишите программу, которая на вход принимает позиции элемента
  в двумерном массиве, и возвращает значение этого элемента
  или же указание, что такого элемента нет.
 */

int horz = new Random().Next(5, 16);
int vert = new Random().Next(5, 16);
int min = new Random().Next(-20, 1);
int max = new Random().Next(10, 100);
Console.WriteLine($"Hello, World!\r\nSize of ({horz},{vert}) at [{min}..{max}] value is generated");

int[,] matrix = FillArray(vert, horz, min, max);
Console.Write(MatrixToString(matrix));

Console.Write(" Enter a horizontal position ");
horz = int.Parse(Console.ReadLine()!);
Console.Write(" Enter vertical position ");
vert = int.Parse(Console.ReadLine()!);
FindAtPosition(matrix, horz, vert);


int[,] FillArray(int size1, int size2, int fmin, int fmax)
{
    int[,] field = new int[size1, size2];

    for (int i = 0; i < field.GetLength(0); i++)
    {
        for (int j = 0; j < field.GetLength(1); j++)
        {
            field[i, j] = new Random().Next(fmin, fmax);
        }
    }
    return field;
}

string MatrixToString(int[,] arr)
{
    string OUT = "";
    int ilen = arr.GetLength(0);
    int jlen = arr.GetUpperBound(1);
    for (int i = 0; i < ilen; i++)
    {
        OUT += "( ";
        for (int j = 0; j < jlen; j++)
        {
            OUT += String.Format("{0,4} ", arr[i, j]);
        }
        OUT += String.Format("{0,4} )\r\n", arr[i, jlen]);
    }
    return OUT;
}

void FindAtPosition(int[,] inFound, int posX, int posY)
{
    if (posX <= inFound.GetLength(0) && posY <= inFound.GetLength(1) && posX >= 0 && posY >= 0)
    {
        Console.WriteLine($"At {posX},{posY} found :{inFound[posY, posX]}");
    }
    else
    {
        Console.WriteLine("this position out of range im array");
    }
}
