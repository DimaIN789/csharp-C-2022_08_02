// Задача 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница


Console.WriteLine("Введи номер дня недели, дружище, и мы подскажем какой это день недели! ;)");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 == 1)
{
    Console.WriteLine("понедельник - день тяжелый");
}

if (number1 == 2)
{
    Console.WriteLine("вторник");
}

if (number1 == 3)
{
    Console.WriteLine("среда - маленькая пятница");
}

if (number1 == 4)
{
    Console.WriteLine("четверг - завтра пятница ;)");
}

if (number1 == 5)
{
    Console.WriteLine("пятница - развратница");
}

if (number1 == 6)
{
    Console.WriteLine("суббота");
}

if (number1 == 7)
{
    Console.WriteLine("воскресенье");
}

if (number1 > 7 || number1 < 1)
{
    Console.WriteLine("извини, но такого дня недели не существует - их же все 7 !?");
}
