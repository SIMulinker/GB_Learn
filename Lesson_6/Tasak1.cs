/*Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/
Console.Write("Hello, user!\r\nEnter count of numbers : ");
int linea = int.Parse(Console.ReadLine()!);

Console.WriteLine(CountOfPositive(linea));


int CountOfPositive(int nums)
{
    int counter = 0;
    for (int i = 0; i < nums; i++)
    {
        Console.Write($"\r\nEnter {i + 1} numbers: ");
        if (int.Parse(Console.ReadLine()!) > 0) counter++;
    }
    return counter;
}
