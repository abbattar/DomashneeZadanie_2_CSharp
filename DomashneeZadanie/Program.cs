/*
// Задача 10
Console.WriteLine("Введите трёхзначное число: ");
int x = Convert.ToInt32(Console.ReadLine());

int SecondNumber(int number)
{
    int newNumber = number / 10;
    int NumberTwo = newNumber % 10;
    return NumberTwo;
}
int y = SecondNumber(x);
Console.WriteLine(y);
*/

// Задача 13
/*
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

bool ThirdNumberFind(int number)
{
    int temp = number / 100;
    bool N1;
    if (temp == 0)
    {
        N1 = false;
    }
    else
    {
        N1 = true;
    }
    return N1;
}
if(ThirdNumberFind(a) == false)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int b = a / 100;
    int c = b % 10;
    Console.WriteLine(c);
}
*/
// Задача 15
Console.Write("Введите число обозначающее день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

bool showWeekEnd(int weekDay)
{
    bool NTF;
    if((weekDay == 6) ^ (weekDay == 7)) // Исключающее "или" - "&&"
    {
        NTF = true;
    }
    else
    {
        NTF = false;
    }
    return NTF;
}
// bool ry = showWeekEnd(day); // Проверка оператора " ^ "
// Console.WriteLine(ry);
if(showWeekEnd(day) == true)
{
    Console.Write("Да, это выходной день");
}
else
{
    Console.Write("Это рабочий день");
}