/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/



Random rnd = new Random();


int[,,] cubes = CreateMatrix(rnd.Next(2, 5), rnd.Next(2, 5), rnd.Next(2, 5));
PrintMatrix(cubes);

int[] SequenceCreate(int size)
{
    int[] sequence = new int[size];
    int rndmin = 10;
    int rndmax = 100; //rmin + size;
    int filled = 1;
    sequence[0] = rndmax;
    while (filled < size)
    {
        bool check = true;
        int temp = rnd.Next(rndmin, rndmax);
        for (int i = 0; i < filled; i++)
        {
            if (temp == sequence[i])
            {
                check = false;
                break;
            }
        }
        if (check)
        {
            sequence[filled] = temp;
            filled++;
        }
    }

    return sequence;
}

int[,,] CreateMatrix(int row, int col, int depth)
{
    int[,,] matrix = new int[row, col, depth];
    int[] linear = SequenceCreate(row * col * depth);
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = linear[index++];
            }
        }
    }
    return matrix;
}


void PrintMatrix(int[,,] matrix)
{
    int dim1 = matrix.GetLength(0);
    int dim2 = matrix.GetLength(1);
    int dim3 = matrix.GetLength(2);
    Console.WriteLine($" Arrays of ({dim1},{dim2},{dim3}) sizes");

    for (int i = 0; i < dim1; i++)
    {
        for (int j = 0; j < dim2; j++)
        {
            for (int k = 0; k < dim3; k++)
            {
                Console.Write($"{matrix[i, j, k],2}-({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
