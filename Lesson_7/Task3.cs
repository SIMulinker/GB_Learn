/*
Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
*/

Console.Write(" Enter a horizontal size  ");
int horz = int.Parse(Console.ReadLine()!);
Console.Write(" Enter vertical size  ");
int vert = int.Parse(Console.ReadLine()!);
Console.Write(" Enter minimal value  ");
int min = int.Parse(Console.ReadLine()!);
Console.Write(" Enter maximal value  ");
int max = int.Parse(Console.ReadLine()!);

int[,] matrix = FillArray(vert, horz, min, max);
Console.Write(MatrixToString(matrix));

Console.WriteLine(" Arifmetic middle of columns : " + SummCol(matrix, horz, vert));


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

string SummCol(int[,] inFound, int posX, int posY)
{
    string result = string.Empty;
    for (int i = 0; i < inFound.GetLength(1); i++)
    {
        double sumTmp = 0;
        for (int j = 0; j < inFound.GetLength(0); j++)
        {
            sumTmp += inFound[j, i];
        }
        sumTmp = sumTmp / inFound.GetLength(0);
        result += string.Format("{0,4:N2} ", sumTmp);
    }
    return result;
}
