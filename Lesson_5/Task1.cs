/*
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
*/
bool DEBUG = false;
Random rnd = new Random();

Console.Write("Hello, user!\r\nEnter a size of array : ");
int linear = int.Parse(Console.ReadLine()!);

/// int[] a2 =FillArray(linear, 100, 999);
// int counts = EvenCount(a2);
//Console.WriteLine(counts);

Console.WriteLine("count even number  " + EvenCount(FillArray(linear, 100, 999)));

//int ccntrr= EvenCount(linear);

int[] FillArray(int fieldsize, int fmin, int fmax)
{
    int[] field = new int[fieldsize];// int[] linear = new int[number];
    
    for (int i = 0; i < field.Length; i++)
    {
        field[i] = rnd.Next(fmin, fmax + 1);
        if (DEBUG == true) Console.Write(field[i] + " ");
    }
    if (DEBUG == true) Console.WriteLine(" --> " + field.Length);
    return field;
}

int EvenCount(int[] arr)
{
    int cntr = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            cntr++;
            if (DEBUG == true) Console.Write(arr[i] + " ");
        }
    }
    return cntr;
}
