/*
Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
*/
Random rnd = new Random();

Console.Write("Hello, user!\r\nEnter a size of array : ");
int linear = int.Parse(Console.ReadLine()!);

Console.Write("\r\nMin numbers of array : ");
double min = double.Parse(Console.ReadLine()!);

Console.Write("\r\nMax numbers of array : ");
double max = double.Parse(Console.ReadLine()!);

double[] atmp = FillArray(linear, min, max);

Console.WriteLine("\r\n array conttains of : " + ArrayToString(atmp));
Console.WriteLine("summ of odd position numbers : " + diff_found(atmp));

//int ccntrr= EvenCount(linear);

double[] FillArray(int fieldsize, double fmin, double fmax)
{
    double[] field = new double[fieldsize];// int[] linear = new int[number];
    for (int i = 0; i < field.Length; i++)
    {
        field[i] = Math.Round((rnd.NextDouble() * (fmax - fmin) + fmin), 3);
    }
    return field;
}

double diff_found(double[] arr)
{
    double pmin = arr[0];
    double pmax = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (pmin > arr[i]) pmin = arr[i];
        if (pmax < arr[i]) pmax = arr[i];
    }
    return Math.Round( (pmax - pmin),3);
}

string ArrayToString(double[] arr)
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
