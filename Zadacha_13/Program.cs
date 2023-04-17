Console.Clear();

System.Console.WriteLine("Введите число: ");
int num = int.Parse(System.Console.ReadLine());
System.Console.WriteLine($"Число, стоящее на третьей строчке: {print(num)}");

// проверка числа что оно больше трех цифр
void check(int a)
{
    if ((a/100)>0) print(a);
    System.Console.WriteLine("Третьей цифры нет!");
}
// программа вывода третьей цифры
int print(int i)
{
    while (i>999)
    {
        i /= 10;
    }
    return i % 10;
}
