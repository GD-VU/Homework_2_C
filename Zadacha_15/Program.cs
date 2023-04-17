Console.Clear();

int d;

Console.Write("Введите число дня недели, от 1 до 7: ");
if(int.TryParse(Console.ReadLine(), out d))
{
    d=d-1;
    if (d<7)
    {
        System.Console.Write("День недели является выходным? - ");
        if (d==0) Console.WriteLine("Нет");
        else if (d==1) Console.WriteLine("Нет");
        else if (d==2) Console.WriteLine("Нет");
        else if (d==3) Console.WriteLine("Нет");
        else if (d==4) Console.WriteLine("Нет");
        else if (d==5) Console.WriteLine("Да");
        else if (d==6) Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Sorry, you're wrong. Day do not exist!");
    }
}
else
{
    Console.WriteLine("Sorry, you're wrong. Day do not exist!");
}