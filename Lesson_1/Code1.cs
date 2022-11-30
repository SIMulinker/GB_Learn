
Console.Write(" Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write(" Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

if(num1 == num2)
{
    Console.WriteLine(" Вообще-то они равны ");
} else if (num1 > num2)
{
    Console.WriteLine(" Первое число больше: " + num1 );
} else
{
    Console.WriteLine(" Второе число больше: " + num2);
}