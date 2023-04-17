Console.Clear();
// Задача 10. Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает вторую цифру этого числа. 
// 456->5; 782->8; 918->1

Main();

//Проверка, работаем дaльше? 
void Main()
{
    bool Work = true;
    while (Work)
    {
        System.Console.WriteLine("Решаем задачу? (y/n)");
        string a = System.Console.ReadLine();
        switch (a)
        {
            case "y": task(); break;
            case "n": Work = false; break;
            default : System.Console.WriteLine("Oops"); Work = false; break;
        }
    }
}

//Если работаем дальше, то...
void task()
{
    System.Console.WriteLine("Введите трехзначное число: ");
    int num = int.Parse(System.Console.ReadLine());
    // Проверка, что число трехзначное
    if ((num>=100)&(num<1000)) 
    {
        // Проверка успешна
        int i = FintSecondNumber(num);
        System.Console.WriteLine($"Вторая цифра числа {num} является {i}");
    }
    // в случае ошибки
    else System.Console.WriteLine("Oops");
}
// Функция определения второй цифры трехзначного числа
int FintSecondNumber(int a)
{
    int result = (a / 10) % 10;
    return result;
}