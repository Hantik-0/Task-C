Console.Write("Введите ваше имя: ");
string firstname = Console.ReadLine();

Console.Write("Введите вашу фамилию: ");
string lastname = Console.ReadLine();

int year = 0;
while (true)
{
    Console.Write("Введите год вашего рождения: ");
    try
    {
        year = Convert.ToInt32(Console.ReadLine());
        break;
    }
    catch
    {
        Console.WriteLine("Неверный формат ввода");
    }
}

string animal = "";
string element = "";

switch (year % 12)
{
    case 0:
        animal = "обезьяна";
        break;
    case 1:
        animal = "петух";
        break;
    case 2:
        animal = "собака";
        break;
    case 3:
        animal = "свинья";
        break;
    case 4:
        animal = "крыса";
        break;
    case 5:
        animal = "бык";
        break;
    case 6:
        animal = "тигр";
        break;
    case 7:
        animal = "кролик";
        break;
    case 8:
        animal = "дракон";
        break;
    case 9:
        animal = "змея";
        break;
    case 10:
        animal = "лошадь";
        break;
    case 11:
        animal = "овца";
        break;
    default:
        animal = "Ошибка";
        break;
}

switch (year % 10)
{
    case 4 or 5:
        element = "зеленый цвет – стихия дерева";
        break;
    case 6 or 7:
        element = "красный цвет – стихия огня";
        break;
    case 8 or 9:
        element = "желтый цвет – стихия земли";
        break;
    case 0 or 1:
        element = "белый цвет – стихия воды";
        break;
    case 2 or 3:
        element = "синий цвет – стихия металла";
        break;
}

switch (animal)
{
    case "error":
        Console.WriteLine("Неверно введена дата");
        break;
    default:
        Console.WriteLine("\nВаше имя: " + firstname + "\nВаша фамилия: " + lastname);
        Console.WriteLine("Вы " + animal + " по китайскому каллендарю");
        Console.WriteLine("Ваша стихия - " + element);
        break;
}
