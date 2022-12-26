/*
Задайте двумерный массив. 
Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
*/

Console.Write(" Enter a horizontal size  ");
int horz = int.Parse(Console.ReadLine()!);
Console.Write(" Enter vertical size  ");
int vert = int.Parse(Console.ReadLine()!);

int[,] matrix = FillArray(vert,horz,1,10); 
Console.WriteLine(MatrixToString(matrix));
int[,] sorted = SortDescendArray(matrix);
Console.WriteLine(MatrixToString(sorted));


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

int[,] SortDescendArray(int[,] noSort)
{
    int size1 = noSort.GetLength(0);
    int size2 = noSort.GetLength(1);

    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2 - 1; j++)
        {
            for (int k = j; k < size2; k++)
            {
                if (noSort[i, j] < noSort[i, k])
                {
                    int temp = noSort[i, k];
                    noSort[i, k] = noSort[i, j];
                    noSort[i, j] = temp;
                }

            }
        }
    }
    return noSort;
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
