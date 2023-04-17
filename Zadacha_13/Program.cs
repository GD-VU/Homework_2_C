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
double print(double i)
{
    //int i = 123;
    // double
    char[] arr = i.ToString().ToCharArray();
    double l = arr.Length;
    double x1 = i/(Math.Pow(10, l-3));
    double ThirdNumber = (x1%10);
    //string result = ThirdNumber.ToString("#.##");
    return Math.Round(ThirdNumber, 0);
}
