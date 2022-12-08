// принимает на вход пятизначное число и проверяет является ли оно палиндромом
string inline = "";
while ((inline.Length - 5) <= 1) //  (inline.Length != 5)--длина строки не будет отрицательной ;)
{
    //проверка сделана неполностью, чтобы не загромождать код... Итак толстый
    Console.WriteLine("Введите пятизначное число :");
    inline = Console.ReadLine()!;
}
// Вариант с разбором строки как массива включать полностью не стал.
// if (inline[0]=='-'){ sign = 1 } else { sign = 0 }
// if ((num[0+sign] == num[4+sign]) && (num[1+sign] == num[3+sign])){ YES }else{ NO }

int numbers = Math.Abs( int.Parse( inline ));

int n1 = numbers / 10000;
int n2 = numbers % 10000 / 1000;
// int n3 = numbers % 1000 / 100; // Осталось для ориентира
int n4 = numbers % 100 / 10;
int n5 = numbers % 10;

if ((n1 == n5) && (n2 == n4))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
