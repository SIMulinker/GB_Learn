/*  принимает на вход числа n, min, max. 
    Затем генерирует массив размером n и заполняет 
    его случайными числами в диапазоне от min до max.
*/

Console.Write("Start program initiated \n\rEnter the SIZE of:");
int size = int.Parse(Console.ReadLine()!);

Console.Write("Enter of Min: ");
int min = int.Parse(Console.ReadLine()!);

Console.Write("Enter of Max: ");
int max = int.Parse(Console.ReadLine()!);

int[] arrays = new int[size];
Random rnd = new Random();


Console.WriteLine( PrintOfArray( FillArray(arrays, min, max) ) );


int[] FillArray(int[] field, int FMIN, int FMAX)
{
    for (int i = 0; i < field.Length; i++)
    {
        field[i] = rnd.Next(FMIN, FMAX + 1);
    }
    return field;
}

string PrintOfArray(int[] arr)
{
    string OUT = "[ ";
    for (int i = 0; i < arr.Length - 1; i++)
    {
        OUT += arr[i] + ", ";
    }
    OUT += arr[arr.Length - 1] + " ]";
    return OUT;
}
