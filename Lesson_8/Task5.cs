/*
Напишите программу, которая заполнит спирально массив 4 на 4.
*/

Random rnd = new Random();

int rndsize = rnd.Next(4, 10);
//int rndsize2 = rnd.Next(4, 10);
int[,] matrix = CreateMatrix(rndsize, rndsize);// from acually contains zero
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(SpiralFunction(matrix));
//Console.ReadLine();


int[,] CreateMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = 0;
        }
    }
    return matrix;
}



int[,] SpiralFunction(int[,] epmtyfield)
{
    // This a correct worked on squared arrays... Rectangular, maybe crashed.
    int dx = 0;
    int dy = 1;
    int x = 0;
    int y = 0;
    int sizepath = epmtyfield.GetLength(0) * epmtyfield.GetLength(1) + 1;
    for (int i = 1; i < sizepath; i++)
    {
        epmtyfield[x, y] = i;
        int nx = x + dx;
        int ny = y + dy;
        if (0 <= nx && nx < epmtyfield.GetLength(0) && 0 <= ny &&
            ny < epmtyfield.GetLength(1) && epmtyfield[nx, ny] == 0)
        {
            x = nx;
            y = ny;
        }
        else
        {
            int temp = dx;
            dx = dy * -1;
            dy = temp;
            x += dx;
            y += dy;
        }
    }
    return epmtyfield;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine();
    }
}
