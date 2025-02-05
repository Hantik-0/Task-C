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
    if (DayBirth <= 31)
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

if ((((DayBirth >= 21 && DayBirth <= 31) && (MonthBirth == 3))) || ((DayBirth <= 19) && (MonthBirth == 4)))
{
    zodiac = "Овен";
}


else if ((((DayBirth >= 20 && DayBirth <= 30) && (MonthBirth == 4))) || ((DayBirth <= 20) && (MonthBirth == 5)))
{
    zodiac = "Телец";
}

else if ((((DayBirth >= 21 && DayBirth <= 31) && (MonthBirth == 5))) || ((DayBirth <= 20) && (MonthBirth == 6)))
{
    zodiac = "Близнецы";
}

else if ((((DayBirth >= 21 && DayBirth <= 30) && (MonthBirth == 6))) || ((DayBirth <= 22) && (MonthBirth == 7)))
{
    zodiac = "Рак";

}

else if ((((DayBirth >= 23 && DayBirth <= 31) && (MonthBirth == 7))) || ((DayBirth <= 22) && (MonthBirth == 8)))
{
    zodiac = "Лев";

}

else if ((((DayBirth >= 23 && DayBirth <= 30) && (MonthBirth == 8))) || ((DayBirth <= 22) && (MonthBirth == 9)))
{
    zodiac = "Дева";
}

else if ((((DayBirth >= 23 && DayBirth <= 31) && (MonthBirth == 9))) || ((DayBirth <= 22) && (MonthBirth == 10)))
{
    zodiac = "Весы";
}

else if ((((DayBirth >= 23 && DayBirth <= 30) && (MonthBirth == 10))) || ((DayBirth <= 21) && (MonthBirth == 11)))
{
    zodiac = "Скорпион";
}

else if ((((DayBirth >= 22 && DayBirth <= 31) && (MonthBirth == 11))) || ((DayBirth <= 21) && (MonthBirth == 12)))
{
    zodiac = "Стрелец";
}

else if ((((DayBirth >= 22 && DayBirth <= 30) && (MonthBirth == 12))) || ((DayBirth <= 19) && (MonthBirth == 1)))
{
    zodiac = "Козерог";
}

else if ((((DayBirth >= 20 && DayBirth <= 31) && (MonthBirth == 1))) || ((DayBirth <= 18) && (MonthBirth == 2)))
{
    zodiac = "Водолей";
}

else if ((((DayBirth >= 19 && DayBirth <= 29) && (MonthBirth == 2))) || ((DayBirth <= 20) && (MonthBirth == 3)))
{
    zodiac = "Рыбы";
}
else
{ zodiac = "Некорректная дата!"; }

Console.WriteLine($"Ваше имя: {FirstsName}, Ваша фамилия: {LastName}, Ваш знак зодиака: {zodiac}");
