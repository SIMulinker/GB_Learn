
Console.Write(" Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write(" Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

Console.Write(" Введите второе число: ");
int num3 = int.Parse(Console.ReadLine()!);

// прямо так не требовалось, мне хотелось заморочиться
// с возможными проверками на нереальные действия

if((num1 == num2)||(num1 == num3))
{
    Console.Write(" Вы шутите ? ");
}
else if((num1 > num2)&&(num1 >num3))
{
    Console.Write("Самое большое первое число: " + num1);
}
else if((num2 > num1)&&(num2 >num3))
{
    Console.Write(" Самое большое второе число: " + num2);
}
else if((num3>num1)&&(num3>num2))
{
    Console.Write(" Самое большое третье число: " + num3);
}
else
{
    Console.Write(" Что-то пошло не так ... ");
}