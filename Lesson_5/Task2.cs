/*
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
*/
bool DEBUG = false;
Random rnd = new Random();

Console.Write("Hello, user!\r\nEnter a size of array : ");
int linear = int.Parse(Console.ReadLine()!);

Console.Write("\r\nMin numbers of array : ");
int min = int.Parse(Console.ReadLine()!);

Console.Write("\r\nMax numbers of array : ");
int max = int.Parse(Console.ReadLine()!);

int[] atmp = FillArray(linear, min, max);

Console.WriteLine("\r\n array conttains of : "+ ArrayToString(atmp));
Console.WriteLine("summ of odd position numbers : " + Odd_Pos_Count(atmp));

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

int Odd_Pos_Count(int[] arr)
{
    int cntr = 0;
    for (int i = 1; i < arr.Length; i+=2 ) //  this a odd positions in human sense ??
    {
        cntr+=arr[i];
        if (DEBUG == true) Console.WriteLine($"{arr[i]} -- {cntr}");
    }
    return cntr;
}

string ArrayToString(int[] arr)
{
    string OUT = "[ ";
    int alen = arr.GetUpperBound(0);
    for (int i = 0; i < alen; i++)
    {
        OUT += arr[i] + ", ";
    }
    OUT += arr[alen] + " ]";
    return OUT;
}
