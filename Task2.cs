Console.WriteLine("Введите свое имя: ");
string FirstsName = Console.ReadLine();

Console.WriteLine("Введите свою фамилию: ");
string LastName = Console.ReadLine();

Console.WriteLine("Месяц вашего рождения? ");
int MonthBirth = Convert.ToInt32(Console.ReadLine());
while (true)
{
    if (MonthBirth <= 12)
    {
        break;
    }
    else
    {
        Console.WriteLine("Некорректная дата!");
        MonthBirth = Convert.ToInt32(Console.ReadLine());
    }

}
Console.WriteLine("День вашего рождения?");
int DayBirth = Convert.ToInt32(Console.ReadLine());
while (true)
{
    if (MonthBirth <= 31)
    {
        break;
    }
    else
    {
        Console.WriteLine("Некорректная дата!");
        DayBirth = Convert.ToInt32(Console.ReadLine());
    }

}
string zodiac = "";

switch (MonthBirth)
{
    case 4:
        if (DayBirth >= 1 && DayBirth <= 19)
        {
            zodiac = "Овен";
        }


        if (DayBirth >= 20 && DayBirth <= 30)
        {
            zodiac = "Телец";
        }
        break;
    case 5:
        if (DayBirth >= 1 && DayBirth <= 20)
        {
            zodiac = "Телец";
        }


        if (DayBirth >= 21 && DayBirth <= 31)
        {
            zodiac = "Близнецы, Ps мой знак зодиака";
        }
        break;

    case 6:
        if (DayBirth >= 1 && DayBirth <= 20)
        {
            zodiac = "Близнецы, Ps мой знак зодиака";
        }


        if (DayBirth >= 21 && DayBirth <= 30)
        {
            zodiac = "Рак";
        }
        break;

    case 7:
        if (DayBirth >= 1 && DayBirth <= 22)
        {
            zodiac = "Рак";
        }


        if (DayBirth >= 23 && DayBirth <= 31)
        {
            zodiac = "Лев";
        }
        break;
    case 8:
        if (DayBirth >= 1 && DayBirth <= 22)
        {
            zodiac = "Лев";
        }


        if (DayBirth >= 23 && DayBirth <= 31)
        {
            zodiac = "Дева";
        }
        break;
    case 9:
        if (DayBirth >= 1 && DayBirth <= 22)
        {
            zodiac = "Дева";
        }


        if (DayBirth >= 23 && DayBirth <= 30)
        {
            zodiac = "Весы";
        }
        break;
    case 10:
        if (DayBirth >= 1 && DayBirth <= 22)
        {
            zodiac = "Весы";
        }


        if (DayBirth >= 23 && DayBirth <= 31)
        {
            zodiac = "Скорпион";
        }
        break;
    case 11:
        if (DayBirth >= 1 && DayBirth <= 21)
        {
            zodiac = "Скорпион";
        }


        if (DayBirth >= 22 && DayBirth <= 30)
        {
            zodiac = "Стрелец";
        }
        break;
    case 12:
        if (DayBirth >= 1 && DayBirth <= 21)
        {
            zodiac = "Стрелец";
        }


        if (DayBirth >= 22 && DayBirth <= 31)
        {
            zodiac = "Козерог";
        }
        break;
    case 1:
        if (DayBirth >= 1 && DayBirth <= 19)
        {
            zodiac = "Козерог";
        }


        if (DayBirth >= 20 && DayBirth <= 31)
        {
            zodiac = "Водолей";
        }
        break;
    case 2:
        if (DayBirth <= 18 && DayBirth >= 1)
        {
            zodiac = "Водолей";
        }

        if (DayBirth >= 19 && DayBirth <= 29)
        {
            zodiac = "Рыбы";
        }
        break;
    case 3:
        if (DayBirth >= 1 && DayBirth <= 20)
        {
            zodiac = "Рыбы";
        }


        if (DayBirth >= 20 && DayBirth <= 31)
        {
            zodiac = "Овен";
        }
        break;


    default:
        Console.WriteLine("Некорректная дата!");
        break;
}
        Console.WriteLine($"Ваше имя: {FirstsName}, Вашa фамилия: {LastName}, Ваш знак зодиака: {zodiac}");
