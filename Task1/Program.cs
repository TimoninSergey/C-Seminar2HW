// Задача №1. Дано число, обозначающее день недели. Выяснить, является ли номер дня недели выходным.

string Holiday(double N)
{
    string Result = ("0");
    if (N == 6)
    {
        Result = ("Суббота - выходной день");
    }
    if (N == 7)
    {
        Result = ("Воскресенье - выходной день");
    }
    if (N < 6)
    {
        Result = ("Будний день");
    }
    if (N > 7)
    {
        Result = ("Нет такого дня");
    }
    return Result;
}

Console.WriteLine("Введите число, означающее день недели");
double Number = double.Parse(Console.ReadLine());

Console.WriteLine(Holiday(Number));

